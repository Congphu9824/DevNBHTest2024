using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogMemberRating
{
    public string? RatingCode { get; set; }

    public string? RatingName { get; set; }

    public decimal? FromMoney { get; set; }

    public decimal? ToMoney { get; set; }

    public string? WithService { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
