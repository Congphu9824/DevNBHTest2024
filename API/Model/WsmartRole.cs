using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartRole
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<WsmartRoleClaim> WsmartRoleClaims { get; set; } = new List<WsmartRoleClaim>();

    public virtual ICollection<WsmartUser> Users { get; set; } = new List<WsmartUser>();
}
