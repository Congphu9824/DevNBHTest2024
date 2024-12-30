using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class DataBusinessResultsLastPeriod
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? UserCode { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? AmountOfMoneyUsd { get; set; }
}
