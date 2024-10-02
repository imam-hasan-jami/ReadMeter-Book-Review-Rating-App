using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.TableModels;

public class User
{
    [Key]
    [Required]
    [Column(TypeName = "VARCHAR")]
    [StringLength(10)]
    public string Username { get; set; }
    [Required]
    [Column(TypeName = "VARCHAR")]
    [StringLength(10)]
    public string Password { get; set; }
    [Required]
    [Column(TypeName = "VARCHAR")]
    public string Email { get; set; }
    [Required]
    public string Name { get; set; }
    public DateTime JoinDate { get; set; } = DateTime.Now;
    public string UserType { get; set; } = "User";
}