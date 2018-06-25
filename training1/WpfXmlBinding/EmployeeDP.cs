
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfXmlBinding
{
    public class EmployeeDP : DependencyObject
    {
        public int mpID
        {
            get { return (int)GetValue(mpIDProperty); }
            set { SetValue(mpIDProperty, value); }
        }
        public static readonly DependencyProperty mpIDProperty =
            DependencyProperty.Register("mpID", typeof(int), typeof(EmployeeDP), new PropertyMetadata(0));



        public string EmpName
        {
            get { return (string)GetValue(EmpNameProperty); }
            set { SetValue(EmpNameProperty, value); }
        }

        public static readonly DependencyProperty EmpNameProperty =
            DependencyProperty.Register("EmpName", typeof(string), typeof(EmployeeDP), new PropertyMetadata("",NamedChangedCallback,coecCallback),ValidationValueCheck);

        private static bool ValidationValueCheck(object value)
        {
            string name = (string)value;
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            return true;
        }

        private static object coecCallback(DependencyObject d, object baseValue)
        {
            string name = (string)baseValue;
            if (name.Length > 10)
            {
                name = name.Substring(0, 10);
            }
            return name;
        }


        private static void NamedChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine($"New Value {e.NewValue} old value {e.OldValue}");
        }
    }
}
