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

namespace Sandbox
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine( TextBox1.Parent);
            //Console.WriteLine(this.ToString());

           foreach (Grid item in LogicalTreeHelper.GetChildren(this))
           {
               foreach (System.Windows.Controls.Control controls in item.Children)
               {
                   if (controls.GetType().Name == "TextBox")
                   {
                        ((TextBox)controls).Focus();
                        ((TextBox)controls).SelectAll();
                   }
               }
           }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Focus();
            TextBox1.SelectAll();
        }
    }
}
