using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ImageDocumentProduct
{
    public string? ViewFile { get; set; }

    public Guid? IdProduct { get; set; }

    public string? ProductCode { get; set; }

    public string? FileNames { get; set; }

    public string? PathLinkImage { get; set; }

    public string? PathLinkLocal { get; set; }

    public string? TypeImgDoc { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public bool IsUploaded { get; set; }
}
