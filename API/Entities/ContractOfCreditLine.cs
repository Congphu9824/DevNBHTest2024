using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ContractOfCreditLine
{
    public Guid Id { get; set; }

    public string? ContractNumber { get; set; }

    public string? ContractContents { get; set; }

    public decimal? ContractValue { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? PurposeCode { get; set; }

    public string? PurposeName { get; set; }

    public string? ObjectAddress { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
