using System.ComponentModel.DataAnnotations;

namespace LimedikosTask.Server.Models;

public class CustomError
{
    [Key]
    public int Id { get; set; }
    public string Message { get; set; }
    public DateTime Created { get; set; }
}
