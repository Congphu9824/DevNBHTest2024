using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogMonth
{
    public Guid Id { get; set; }

    public string? CodeMonth { get; set; }

    public string? NameMonth { get; set; }

    public bool IsActive { get; set; }
}
