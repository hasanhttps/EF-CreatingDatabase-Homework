using System;
using EF_Library_Database_HW.Enums;
using System.ComponentModel.DataAnnotations;

namespace EF_Library_Database_HW.Entyties;

public class Students : BaseEntity {

    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string PhoneNumber { get; set; }

    // Navigation Property

    public ICollection<Books> Books { get; set; }
}