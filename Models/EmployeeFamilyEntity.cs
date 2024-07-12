using System.ComponentModel.DataAnnotations;
namespace Employee.Models;

public class EmployeeFamilyEntity
{
    [Key]
    public int Id { get; init; }

    public string FirstName { get; set; } = null!;

    public string? Surname { get; set; }

    public string Relationship { get; set; } = null!;

    public int MyProperty { get; set; }

    public int EmpId { get; set; }


    public virtual EmployeeEntity EmployeesEntity { get; set; } = null!;
}
