using System;
using EF_Library_Database_HW.Enums;
using System.ComponentModel.DataAnnotations;

namespace EF_Library_Database_HW.Entyties;

public class BaseEntity {

    [Key]
    public int Id { get; set; }
    public DataStatus status { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime ModifiedTime { get; set; }
}