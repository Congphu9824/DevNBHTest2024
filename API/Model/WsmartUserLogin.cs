using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartUserLogin
{
    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;

    public string? ProviderDisplayName { get; set; }

    public string UserId { get; set; } = null!;

    public virtual WsmartUser User { get; set; } = null!;
}
