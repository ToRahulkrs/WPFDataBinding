using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Appliction = System.Windows.Application;

namespace WPFApplictionModel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    ShutdownMode = ShutdownMode.OnLastWindowClose;
        //    ShutdownMode = ShutdownMode.OnExplicitShutdown;
        //    ShutdownMode = ShutdownMode.OnMainWindowClose;
        //    base.OnStartup(e);
        //}
        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);
        //}
        //protected override void OnDeactivated(EventArgs e)
        //{
        //    base.OnDeactivated(e);
        //}
        //protected override void OnExit(ExitEventArgs e)
        //{
        //    base.OnExit(e);
        //}

        protected override void OnStartup(StartupEventArgs e)
        {
            DispatcherUnhandledException += MainUIThreadUnhandledException;
            Current.Dispatcher.UnhandledException += DispatcherOnUnhandledException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerExceptionOnUnobservedTaskException;
        }

        #region
        private void TaskSchedulerExceptionOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            Debug.WriteLine("TaskSchedulerExceptionOnUnobservedTaskException");
            e.SetObserved();
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Debug.WriteLine("CurrentDomainOnUnhandledException");
        }

        private void DispatcherOnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            Debug.WriteLine("DispatcherOnUnhandledException");
            e.Handled = true;
        }

        private void MainUIThreadUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            Debug.WriteLine("MainUIThreadUnhandledException");
            e.Handled = true;
        }
        #endregion
    }
}
