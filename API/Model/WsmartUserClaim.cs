using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartUserClaim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string UserId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual WsmartUser User { get; set; } = null!;
}
