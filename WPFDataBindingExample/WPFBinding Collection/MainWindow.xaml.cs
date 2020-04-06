using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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

namespace WPFBindingCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Person { get; private set; }
        public MainWindow()
        {
            Person = new ObservableCollection<Person>()
            {
                new Person(){Name="Rahul",LastName="Kumar",Age=25,PicturePath="C:\\Project-Result\\WPFDataBinding\\WPFDataBindingExample\\WPFBinding Collection\\Image\\Image1.jpg"},
                new Person(){Name="Pankaj",LastName="Kumar",Age=28,PicturePath="C:\\Project-Result\\WPFDataBinding\\WPFDataBindingExample\\WPFBinding Collection\\Image\\Image2.jpg"}
            };
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person.Add(new Person
            {
                Name="Aashish",
                LastName="Kumar",
                Age=30,
                PicturePath= "C:\\Project-Result\\WPFDataBinding\\WPFDataBindingExample\\WPFBinding Collection\\Image\\Image3.jpg"
            });
        }
    }
}
