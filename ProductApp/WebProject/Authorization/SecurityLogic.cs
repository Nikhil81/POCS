using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Authorization
{
    public class SecurityLogic
    {
        public static bool Login(string userName, string password)
        {
            EmployeeDBEntities _empDB = new EmployeeDBEntities();

            return _empDB.Users.Any(users => users.UserName.Equals(userName,StringComparison.OrdinalIgnoreCase)  && users.Password == password);
        }
    }
}