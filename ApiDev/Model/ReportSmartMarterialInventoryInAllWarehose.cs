using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportSmartMarterialInventoryInAllWarehose
{
    public string ColumnSelect { get; set; } = null!;

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? PriceImp { get; set; }

    public double? PriceExp { get; set; }

    public double? PriceRetail { get; set; }

    public double? K01 { get; set; }

    public double? K02 { get; set; }

    public double? K03 { get; set; }

    public double? K04 { get; set; }

    public double? K05 { get; set; }

    public double? K07 { get; set; }

    public double? K08 { get; set; }

    public double? K09 { get; set; }

    public double? K10 { get; set; }

    public double? K11 { get; set; }

    public double? K12 { get; set; }

    public double? Kall { get; set; }

    public decimal? AmountOfMoneyEnd { get; set; }
}
