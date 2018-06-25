using Employee;
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

namespace training1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Employee class ref
        EmployeeClass emp;
        Employees emps;
        public MainWindow()
        {
            InitializeComponent();
            DisplayUI();
        }

        private void DisplayUI()
        {
            emp = new EmployeeClass();
            emp.EmpId = 101;
            emp.Name = "Nikhil";
            emp.Salary = 1;
            //this.DataContext = emp;
            txtAddr.DataContext = emp;

            emps = new Employees();
            empGrid.ItemsSource = emps;
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            emp.Name = txtNewName.Text;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            EmployeeClass _emp = new EmployeeClass();
            _emp.EmpId = Convert.ToInt16(textBox1.Text);
            _emp.Name = textBox.Text;
            _emp.Salary = Convert.ToInt16(textBox2.Text);
            emps.Add(_emp);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = empGrid.SelectedIndex;
                emps.RemoveAt(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row");
            }
        }
    }
}
