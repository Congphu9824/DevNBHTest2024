using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesSmartDataWarehouseSent
{
    public string DataType { get; set; } = null!;

    public string? WarehoseData { get; set; }

    public string WarehoseCode { get; set; } = null!;

    public string WarehoseName { get; set; } = null!;

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public decimal AmountOfMoney { get; set; }
}
