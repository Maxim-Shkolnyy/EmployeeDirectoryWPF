using EmployeeDirectoryWPF.Model;
using EmployeeDirectoryWPF.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDirectoryWPF.Services
{
    public static class DbMethods
    {
        public static List<Employee> GetAllDepartments()
        {
            using (MyDbContext db = new MyDbContext())
            {
                var result = db.Employees.ToList();
                return result;
            }
        }
    }
}
