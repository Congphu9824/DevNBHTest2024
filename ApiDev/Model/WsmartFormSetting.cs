using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class WsmartFormSetting
{
    public Guid Id { get; set; }

    public string? TypeForm { get; set; }

    public string? CodeForm { get; set; }

    public string? NameForm { get; set; }

    public string? NameTable { get; set; }

    public string? StoredProcedure { get; set; }

    public string? Parameter { get; set; }

    public string? RequiredField { get; set; }

    public string? ColumnPosition { get; set; }

    public bool? AllowExcelExport { get; set; }

    public bool? AllowFiltering { get; set; }

    public bool? AllowGrouping { get; set; }

    public bool? HideDropArea { get; set; }

    public bool? AllowPaging { get; set; }

    public bool? AllowPdfExport { get; set; }

    public bool? AllowReordering { get; set; }

    public bool? AllowResizing { get; set; }

    public bool? AllowSelection { get; set; }

    public bool? AllowSorting { get; set; }

    public bool? AllowTextWrap { get; set; }

    public bool? EnableHover { get; set; }

    public bool? ShowColumnChooser { get; set; }

    public bool? AllowAdding { get; set; }

    public bool? AllowEditing { get; set; }

    public bool? AllowDeleting { get; set; }

    public string? Height { get; set; }

    public string? Width { get; set; }

    public string? GroupBy { get; set; }

    public string? OrderBy { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
