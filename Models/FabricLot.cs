using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fabric_Net.Models;

public class FabricLot  
{
	[Key]
	public int Id { get; set; }

	public DateTime DayIn { get; set; }

	public int FabricSizeId { get; set; }

	[ForeignKey(nameof(FabricSizeId))]
	public FabricSize? FabricSize { get; set; }

	public int FabricTypeId { get; set; }

	[ForeignKey(nameof(FabricTypeId))]
	public FabricType? FabricType { get; set; }
}
