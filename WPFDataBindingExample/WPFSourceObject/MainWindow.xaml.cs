using System;
using System.Collections.Generic;
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

namespace WPFSourceObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Craftsman Craftsman { get; set; }
        public MainWindow()
        {
            Craftsman = new Craftsman { Age=25, LastName="Kumar", Name="Rahul", PicturePath="C:\\Project-Result\\WPFDataBinding\\WPFDataBindingExample\\WPFSourceObject\\Image\\Image1.jpg"};
            InitializeComponent();

            //Binding pictureBinding = new Binding
            //{
            //    Source = Craftsman,
            //    Path = new PropertyPath("PicturePath")
            //};
            //crftsmanPicture.SetBinding(Image.SourceProperty, pictureBinding);

            ////Binding name = new Binding
            ////{
            ////    Source = Craftsman,
            ////    Path = new PropertyPath("Name")
            ////};
            ////Name.SetBinding(TextBlock.TextProperty, name);

            //Binding lastName = new Binding
            //{
            //    Source = Craftsman,
            //    Path = new PropertyPath("LastName")
            //};

            //LastName.SetBinding(TextBlock.TextProperty, lastName);

            //Binding age = new Binding
            //{
            //    Source = Craftsman,
            //    Path = new PropertyPath("Age")
            //};

            //Age.SetBinding(TextBox.TextProperty, age);
        }

        private void changeAge_onClick(object sender, RoutedEventArgs e)
        {
            Craftsman.Age = 80;
        }
    }
}
