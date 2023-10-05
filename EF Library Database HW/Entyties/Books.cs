using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace EF_Library_Database_HW.Entyties;

public class Books : BaseEntity {

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int PageCount { get; set; }

    // Foreign Key

    public int AuthorId { get; set; }
    public int BookTypeId { get; set; } 

    // Navigation Property

    public Authors Author { get; set; }
    public BooksTypes BookType { get; set; }
    public ICollection<Students> Students { get; set; }

}