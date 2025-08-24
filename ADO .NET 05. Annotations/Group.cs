// Annotations
using System.ComponentModel.DataAnnotations;

class Group 
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    [Required]
    [Range(0, 12)] // 0 ile 12 arasında olmalıdır
    public int GroupRating { get; set; }
    [Required]
    [Range(1, 4)]
    public int CourseYear { get; set; }
    public List<Student> Students { get; set; } 

}


