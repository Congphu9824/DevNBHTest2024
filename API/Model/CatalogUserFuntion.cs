using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogUserFuntion
{
    public Guid Id { get; set; }

    public string? UserFuntionCode { get; set; }

    public string? UserFuntionName { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }
}
