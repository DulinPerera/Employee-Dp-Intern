using System.ComponentModel.DataAnnotations;
namespace Employee.Models;

public class EmployeeEntity
{
        [Key]
        public int EmpId { get; init; }
        public string? Initials { get; set; }
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public DateTime DOB { get; set; }
        public string? Status { get; set; }


        public virtual EmployeeFamilyEntity EmployeeFamilyEntity { get; set; } = null!;
}
