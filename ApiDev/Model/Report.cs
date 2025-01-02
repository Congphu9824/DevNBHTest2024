using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class Report
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? TypeReport { get; set; }

    public string? TypeNameReport { get; set; }

    public string? CodeReport { get; set; }

    public string? NameReport { get; set; }

    public string? ReportFileName { get; set; }

    public string? ExcelFileName { get; set; }

    public string? StoreName { get; set; }

    public string? Paramater { get; set; }

    public bool? ByNoAcount { get; set; }

    public bool? ByContract { get; set; }

    public bool? ByConstruction { get; set; }

    public bool? ByObject { get; set; }

    public bool? ByWarehouse { get; set; }

    public bool? ByRevenue { get; set; }

    public bool? ByExpense { get; set; }

    public bool? ByMaterials { get; set; }

    public bool? ByProject { get; set; }

    public bool? ByFunding { get; set; }

    public string? DocTemplate { get; set; }

    public string? ImpDecision { get; set; }

    public string? Notes { get; set; }

    public bool ByProductionActivities { get; set; }

    public bool ByRoom { get; set; }

    public string? TableName { get; set; }

    public string? GroupHead { get; set; }

    public string? GroupContents1 { get; set; }

    public string? GroupContents2 { get; set; }

    public string? FielsSelect { get; set; }

    public int? PositionSum { get; set; }

    public string? GroupHeadText { get; set; }

    public string? GroupContents1Text { get; set; }

    public string? GroupContents2Text { get; set; }

    public int? PositionSumEnd { get; set; }

    public string? TemplateExcelCode { get; set; }

    public string? TemplateExcelText { get; set; }

    public bool SendMailObject { get; set; }

    public bool ByAmountMoney { get; set; }

    public string? OrderByContents { get; set; }
}
