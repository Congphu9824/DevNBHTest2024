using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class WsmartUserToken
{
    public string UserId { get; set; } = null!;

    public string LoginProvider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual WsmartUser User { get; set; } = null!;
}
