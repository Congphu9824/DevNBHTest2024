using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogAsset
{
    public string AssetCode { get; set; } = null!;

    public string? AssetName { get; set; }

    public string? Units { get; set; }

    public double? Price { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public decimal? AssetValues { get; set; }

    public decimal? OriginalPrice { get; set; }

    public double? DepreciationPeriod { get; set; }

    public double? DepreciationValuePerMonth { get; set; }

    public DateTime? DepreciationEndDate { get; set; }

    public string AssetGroupCode { get; set; } = null!;

    public string? AssetGroupName { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public Guid Identifier { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? RoomCode { get; set; }

    public string? RoomName { get; set; }

    public double? ValuePerMonthRules { get; set; }

    public double? PercentPerAllocationPeriod { get; set; }

    public int? ProductionYear { get; set; }

    public string? Origin { get; set; }

    public double? Wattage { get; set; }
}
