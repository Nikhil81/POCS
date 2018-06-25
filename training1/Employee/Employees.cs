using System.Collections.ObjectModel;

namespace Employee
{
    public class Employees : ObservableCollection<EmployeeClass>
    {
        public Employees()
        {
            this.Add(new EmployeeClass { Name = "A", EmpId = 1, Salary = 10 });
            this.Add(new EmployeeClass { Name = "B", EmpId = 2, Salary = 20 });
            this.Add(new EmployeeClass { Name = "C", EmpId = 3, Salary = 12 });
            this.Add(new EmployeeClass { Name = "D", EmpId = 4, Salary = 15 });
        }
    }
}
