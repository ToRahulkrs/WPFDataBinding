using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApplictionModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ThrowException()
        {
            throw new Exception();
        }
        #region
        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);
        //}
        //protected override void OnContentRendered(EventArgs e)
        //{
        //    base.OnContentRendered(e);
        //}
        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    e.Cancel = true;
        //    base.OnClosing(e);
        //}
        //protected override void OnDeactivated(EventArgs e)
        //{
        //    base.OnDeactivated(e);
        //}
        //protected override void OnClosed(EventArgs e)
        //{
        //    base.OnClosed(e);
        //}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        #endregion
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            //Task.Run(() =>
            //{
            //    Application.Current.Dispatcher.Invoke(() =>
            //    {
            //        Start.Content = "Stop";

            //    });
            //});
            //Thread.Sleep(10000);
            //Thread t = new Thread(ThrowException);
            //t.Start();

            //ThrowException();

            Task.Run(() =>
            {
                throw new Exception();
            });
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
