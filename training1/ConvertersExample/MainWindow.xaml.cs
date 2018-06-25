using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ConvertersExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PrintLogicalTree(0, this);
        }

        protected override void OnContentRendered(EventArgs e)
        {
            PrintVisualTree(0, this);
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            rect1.Fill = new SolidColorBrush(Colors.Red);
        }
        private void PrintLogicalTree(int depth, object obj)
        {
            Debug.WriteLine(new string(' ', depth) + obj);
            if (!(obj is DependencyObject)) return;

            foreach (object child in LogicalTreeHelper.GetChildren(obj as DependencyObject))
            {
                PrintLogicalTree(depth + 1, child);
            }

        }

        private void PrintVisualTree(int depth, DependencyObject obj)
        {
            Debug.WriteLine(new string(' ', depth) + obj);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                PrintVisualTree(depth + 1, VisualTreeHelper.GetChild(obj, i));
            }
            {

            }
        }
    }
}
