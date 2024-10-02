using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.TableModels;

public class Recommendation
{
    public int RecommendationId { get; set; }

    [Required]
    [ForeignKey("User")]
    public string Username { get; set; }
    public User User { get; set; }

    [Required]
    [ForeignKey("Book")]
    public int BookId { get; set; }
    public Book Book { get; set; }

    [Required]
    public bool IsRecommended { get; set; }
    public DateTime RecommendationDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
}