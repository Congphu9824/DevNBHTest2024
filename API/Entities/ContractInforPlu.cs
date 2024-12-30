using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ContractInforPlu
{
    public Guid Id { get; set; }

    public Guid? IdData { get; set; }

    public string? NumberContract { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ContentsTransaction { get; set; }

    public decimal? ValueTransaction { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public string? Notes { get; set; }
}
