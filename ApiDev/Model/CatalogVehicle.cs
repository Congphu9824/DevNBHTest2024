using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogVehicle
{
    public string? Vehicles { get; set; }

    public string? LicensePlates { get; set; }

    public string? DriverName { get; set; }

    public string? DrivingLicense { get; set; }

    public string? CitizenIdentification { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? PlaceOfIssue { get; set; }

    public double? CargoCompartment1 { get; set; }

    public double? CargoCompartment2 { get; set; }

    public double? CargoCompartment3 { get; set; }

    public double? CargoCompartment4 { get; set; }

    public double? CargoCompartment5 { get; set; }

    public double? CargoCompartment6 { get; set; }

    public double? CargoCompartment7 { get; set; }

    public double? CargoCompartment8 { get; set; }

    public double? TotalCargoCompartment { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? Notes { get; set; }
}
