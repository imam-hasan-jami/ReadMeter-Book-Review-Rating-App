using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.TableModels;

public class Book
{
    public int BookId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public DateTime PublishDate { get; set; }
    [Required]
    public string Genre { get; set; }

    [Required]
    [ForeignKey("Author")]
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}