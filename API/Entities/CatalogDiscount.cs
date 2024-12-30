using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogDiscount
{
    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? Taxcode { get; set; }

    public string? ObjectAddress { get; set; }

    public double? DiscountRate { get; set; }

    public string? Notes { get; set; }

    public string? ContractNo { get; set; }

    public DateTime? SignDay { get; set; }

    public string? GroupName { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? DataType { get; set; }

    public double? PriceProduct { get; set; }

    public double? PriceBottle { get; set; }

    public string? Barcode { get; set; }
}
