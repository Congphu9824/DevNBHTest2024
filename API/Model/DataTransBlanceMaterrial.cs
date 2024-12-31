using System;
using System.Collections.Generic;

namespace API.Model;

public partial class DataTransBlanceMaterrial
{
    public Guid Id { get; set; }

    public string? CodeUnit { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public string? AccountSymbol { get; set; }

    public string? AccountName { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? OpeningDebit { get; set; }

    public decimal? OpeningCredit { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? RevenueExpenseCode { get; set; }

    public string? RevenueExpenseName { get; set; }

    public string? ConstructionCode { get; set; }

    public string? ConstructionName { get; set; }

    public string? ContractCode { get; set; }

    public string? ContractName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? RoomCode { get; set; }

    public string? RoomName { get; set; }

    public string? ProductionActivitieCode { get; set; }

    public string? ProductionActivitieName { get; set; }

    public string? FundingSourceCode { get; set; }

    public string? FundingSourceName { get; set; }

    public string? Notes { get; set; }
}
