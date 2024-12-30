using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class WsmartRuleFuntion
{
    public Guid Id { get; set; }

    public Guid? IdUser { get; set; }

    public Guid? IdMenu { get; set; }

    public string? MenuName { get; set; }

    public bool IsActive { get; set; }

    public string? Note { get; set; }
}
