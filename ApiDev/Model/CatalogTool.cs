using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogTool
{
    public string ToolsCode { get; set; } = null!;

    public string? ToolsName { get; set; }

    public string? Units { get; set; }

    public double? Price { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public decimal? ToolsValues { get; set; }

    public decimal? OriginalPrice { get; set; }

    public double? DepreciationPeriod { get; set; }

    public double? DepreciationValuePerMonth { get; set; }

    public DateTime? DepreciationEndDate { get; set; }

    public string? ToolsGroupCode { get; set; }

    public string? ToolsGroupName { get; set; }

    public int? ProductionYear { get; set; }

    public string? Origin { get; set; }

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

    public string? ToolsSourceCode { get; set; }

    public string? ToolsSourceName { get; set; }

    public string? PurposeCode { get; set; }

    public string? PurposeName { get; set; }

    public string? OriginCode { get; set; }

    public string? OriginName { get; set; }

    public string? DepMeCode { get; set; }

    public string? DepMeName { get; set; }

    public double? PercentPerAllocationPeriod { get; set; }

    public double? Wattage { get; set; }
}
