using Dapper.Contrib.Extensions;

namespace App.Models;

[Table("Collaborator")]
public class Collaborator
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
