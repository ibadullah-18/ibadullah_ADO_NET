// Annotations
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Teacher 
{
    [Key] // Primary Key edir mes teacher Id de id sozu yoxdu ona gore de key yazanda Primary key olur
    [Column("Id")]
    public int TeacherId{ get; set; }
    [Required]
    [MaxLength(20)] 
    public string? FirstName { get; set; }
    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }
    [Required]
    [Column(TypeName = "varchar(30)")] // - varchar(20) olaraq bazada saxlayir
    public string? Email { get; set; }
    public double Salary { get; set; }
    public double Bonus { get; set; }
}


