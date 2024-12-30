using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartListDataImportedExcel
{
    public string? DataType { get; set; }

    public string? CreateDate { get; set; }

    public string? NumberImport { get; set; }

    public string? CreatedBy { get; set; }
}
