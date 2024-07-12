
using System.ComponentModel.DataAnnotations;

namespace Employee.Models;

    public class FamilyEntity
    {
        [Key]
        public int Id { get; set; }
        public string Initials { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string DOB { get; set; }
        public string Status { get; set; }
    }