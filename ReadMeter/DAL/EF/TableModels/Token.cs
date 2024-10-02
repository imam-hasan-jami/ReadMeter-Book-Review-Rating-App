using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.TableModels;

public class Token
{
    public int Id { get; set; }
    public string Key { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ExpiredAt { get; set; }
    [ForeignKey("User")]
    public string Username { get; set; }
    public User User { get; set; }
}