using System.ComponentModel.DataAnnotations;

namespace Fabric_Net.Models;

public class FabricSize
{
    [Key]
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public decimal Height { get; set; }
	public decimal Width { get; set; }
}
