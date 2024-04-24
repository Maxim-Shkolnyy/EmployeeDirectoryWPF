using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectoryWPF.Model
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;


    //public class Employee : INotifyPropertyChanged
    //{
    //    private int id;
    //    private string name;
    //    private string address;
    //    private DateTime dateOfBirth;
    //    private string phone;
    //    private string jobTitle;
    //    private bool status;
    //    private decimal salary;
    //    private DateTime dateOfHiring;
    //    private DateTime? dateOfRetirement;

        //public event PropertyChangedEventHandler PropertyChanged;

        public class Employee
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //public int Id
    //{
    //    get { return id; }
    //    set { id = value; OnPropertyChanged(); }
    //}

    //[Required(ErrorMessage = "Name is required")]
    //public string Name
    //{
    //    get { return name; }
    //    set { name = value; OnPropertyChanged(); }
    //}

    //[Required(ErrorMessage = "Address is required")]
    //public string Address
    //{
    //    get { return address; }
    //    set { address = value; OnPropertyChanged(); }
    //}

    //[Required(ErrorMessage = "Date of Birth is required")]
    //public DateTime DateOfBirth
    //{
    //    get { return dateOfBirth; }
    //    set { dateOfBirth = value; OnPropertyChanged(); }
    //}

    //[Required(ErrorMessage = "Phone is required")]
    //public string Phone
    //{
    //    get { return phone; }
    //    set { phone = value; OnPropertyChanged(); }
    //}

    //[Required(ErrorMessage = "Job Title is required")]
    //public string JobTitle
    //{
    //    get { return jobTitle; }
    //    set { jobTitle = value; OnPropertyChanged(); }
    //}

    //public bool Status
    //{
    //    get { return status; }
    //    set { status = value; OnPropertyChanged(); }
    //}

    //[Required(ErrorMessage = "Salary is required")]
    //public decimal Salary
    //{
    //    get { return salary; }
    //    set { salary = value; OnPropertyChanged(); }
    //}

    //[Required(ErrorMessage = "Date of Hiring is required")]
    //public DateTime DateOfHiring
    //{
    //    get { return dateOfHiring; }
    //    set { dateOfHiring = value; OnPropertyChanged(); }
    //}

    //public DateTime? DateOfRetirement
    //{
    //    get { return dateOfRetirement; }
    //    set { dateOfRetirement = value; OnPropertyChanged(); }
    //}

    //protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}
    //}
}
