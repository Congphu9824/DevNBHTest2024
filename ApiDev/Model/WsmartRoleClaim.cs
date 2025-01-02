using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class WsmartRoleClaim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Group { get; set; }

    public string RoleId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual WsmartRole Role { get; set; } = null!;
}
