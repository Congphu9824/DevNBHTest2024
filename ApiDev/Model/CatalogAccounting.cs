using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogAccounting
{
    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public int CodeUnit { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? AccountSymbol { get; set; }

    public string? DebitSide { get; set; }

    public string? DebitObjectCode { get; set; }

    public string? DebitObjectName { get; set; }

    public string? CreditSide { get; set; }

    public string? CreditObjectCode { get; set; }

    public string? CreditObjectName { get; set; }

    public string? RevenueExpenseCode { get; set; }

    public string? RevenueExpenseName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public int IdAsc { get; set; }

    public Guid? Id { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? DataType1 { get; set; }

    public string? DataName1 { get; set; }

    public int? CodeUnit1 { get; set; }

    public string? CatalogAccounting1 { get; set; }

    public string? ContractName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? ContractNumber { get; set; }

    public string? ContentContract { get; set; }

    public string? ContractCode { get; set; }

    public string? ProductActivCode { get; set; }

    public string? ProductActivName { get; set; }
}
