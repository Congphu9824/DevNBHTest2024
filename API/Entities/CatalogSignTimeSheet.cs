using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogSignTimeSheet
{
    public string? SignTimeSheet { get; set; }

    public string? Description { get; set; }

    public double? SalaryRate { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public double? ConversionOfWorkingDays { get; set; }
}
