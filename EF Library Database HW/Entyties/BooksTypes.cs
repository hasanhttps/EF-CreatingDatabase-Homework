using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Library_Database_HW.Entyties;

public class BooksTypes : BaseEntity {

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    // Navigation Property

    public ICollection<Books> Books { get; set; }
}