using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogVouchersInherit
{
    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public int? CodeUnit { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? DataTypeDes { get; set; }

    public string? DataNameDes { get; set; }

    public string? ReasonCodeDes { get; set; }

    public string? ReasonNameDes { get; set; }

    public int? CodeUnitDes { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
