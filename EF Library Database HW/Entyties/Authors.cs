using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Library_Database_HW.Entyties;

public class Authors : BaseEntity {

    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation Property

    public ICollection<Books> books { get; set; }
}