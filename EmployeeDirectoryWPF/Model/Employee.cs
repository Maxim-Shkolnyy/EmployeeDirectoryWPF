﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDirectoryWPF.Model;

public class Employee : IDataErrorInfo
{
    public string this[string columnName]
    {
        get
        {
            string? error = null;

            switch (columnName)
            {
                case "Name":
                    if (string.IsNullOrWhiteSpace(Name) || Name.Length < 4)
                        error = "Ім'я повинно містити принаймні 4 символи.";
                    break;
                case "Address":
                    if (string.IsNullOrWhiteSpace(Address) || Address.Length < 4)
                        error = "Адреса повинна містити принаймні 4 символи.";
                    break;
                case "DateOfHiring":
                    if (DateOfRetirement.HasValue && DateOfRetirement.Value < DateOfHiring)
                        error = "Дата звільнення не може бути раніше дати найму.";
                    break;
            }

            return error;
        }
    }

    public string Error => throw new NotImplementedException();


    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Phone { get; set; }
    public string? JobTitle { get; set; }
    public string? Status { get; set; }
    public decimal Salary { get; set; }
    public DateTime DateOfHiring { get; set; } = DateTime.Now;
    public DateTime? DateOfRetirement { get; set; }

}










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
