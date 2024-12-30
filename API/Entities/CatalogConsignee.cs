using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogConsignee
{
    public string? ObjectName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PlaceOfIssue { get; set; }

    public string? CitizenIdentification { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public DateTime? BirthDay { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? Notes { get; set; }
}
