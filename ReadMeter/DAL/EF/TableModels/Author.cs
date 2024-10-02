using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.TableModels;

public class Author
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }
    [Required]
    [StringLength(30)]
    public string Name { get; set; }
    [Required]
    [StringLength(30)]
    [Column(TypeName = "VARCHAR")]
    public string Email { get; set; }
    [Required]
    [StringLength(200)]
    public string Bio { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }

    // Navigation property
    public ICollection<Book> Books { get; set; }
    public Author()
    {
        Books = new List<Book>();
    }
}