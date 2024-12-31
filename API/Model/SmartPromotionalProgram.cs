using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartPromotionalProgram
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public int? CodeUnit { get; set; }

    public string? NumberOfVouchers { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProgramCode { get; set; }

    public string? ProgramName { get; set; }

    public string? FormOfPromotionCode { get; set; }

    public string? FormOfPromotionName { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool WaitActive { get; set; }

    public bool IsAvtive { get; set; }

    public int IdAsc { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? CodeData { get; set; }

    public string? NameData { get; set; }
}
