using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartInventorySheet
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public string InvNumber { get; set; } = null!;

    public int CodeUnit { get; set; }

    public string CodeWarehose { get; set; } = null!;

    public string CodeUser { get; set; } = null!;

    public DateTime InventoryTime { get; set; }

    public string? InventoryArea { get; set; }

    public bool FinishedInventory { get; set; }

    public bool? IsActive { get; set; }

    public bool? ClosingStock { get; set; }

    public string? IpAddress { get; set; }

    public string? DeviceName { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public bool NegativeNumbers { get; set; }

    public string? NoteInvSheet { get; set; }
}
