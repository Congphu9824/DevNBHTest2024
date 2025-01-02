using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogImageProduct
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public bool IsActive { get; set; }

    public Guid? ProductId { get; set; }

    public string? CodeProduct { get; set; }

    public string? ImageName { get; set; }

    public string? PathImage { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public string? TypeImgDoc { get; set; }

    public string? ViewFile { get; set; }

    public string? PathLinkLocal { get; set; }
}
