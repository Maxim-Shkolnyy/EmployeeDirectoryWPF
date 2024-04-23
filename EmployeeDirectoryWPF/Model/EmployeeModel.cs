using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectoryWPF.Model
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? JobTitle { get; set; }
        public string? Status { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfHiring { get; set; } = DateTime.Now;
        public DateTime? DateOfRetirement { get; set; }
    }
}
