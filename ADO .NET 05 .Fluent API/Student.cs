// Annotations
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Student 
{
    public int Id { get; set; }
    [Required]// - null etmir yeni NOT NULL olur
    [MaxLength(20)] // - max 20 karakter olur
    public string? FirstName { get; set; }
    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }

    [ForeignKey("Group")] // - GroupId ile Group tablosuna baglanir
    [Column("Id_Group")] // - GroupId kolonunun adini Id_Group olaraq deyisir amma kodda GroupId olaraq qalir
    public int GroupId { get; set; }

    public virtual Group Group { get; set; } // - navigation property

}


