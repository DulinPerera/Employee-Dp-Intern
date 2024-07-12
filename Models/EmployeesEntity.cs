
using System.ComponentModel.DataAnnotations;

namespace Employee.Models;

public class EmployeesEntity
{
        [Key]
        public int Id { get; set; }
        public string? Initials { get; set; }
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public DateTime DOB { get; set; }
        public string? Status { get; set; }
}
