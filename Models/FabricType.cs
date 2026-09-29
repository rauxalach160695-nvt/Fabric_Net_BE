using System.ComponentModel.DataAnnotations;

namespace Fabric_Net.Models;

public class FabricType
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string color { get; set; } = null!;
}

