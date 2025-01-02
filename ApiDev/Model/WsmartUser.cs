using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class WsmartUser
{
    public string Id { get; set; } = null!;

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? DisplayName { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? Provider { get; set; }

    public string? TenantId { get; set; }

    public string? TenantName { get; set; }

    public string? ProfilePictureDataUrl { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsLive { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiryTime { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string? WarehoseCode { get; set; }

    public int? CodeUnit { get; set; }

    public int? NumberOf { get; set; }

    public string? AddressUser { get; set; }

    public bool? HeadShops { get; set; }

    public DateTime? Created { get; set; }

    public string? GrpUser { get; set; }

    public string? Chucvu { get; set; }

    public string? Dob { get; set; }

    public virtual ICollection<WsmartUserClaim> WsmartUserClaims { get; set; } = new List<WsmartUserClaim>();

    public virtual ICollection<WsmartUserLogin> WsmartUserLogins { get; set; } = new List<WsmartUserLogin>();

    public virtual ICollection<WsmartUserToken> WsmartUserTokens { get; set; } = new List<WsmartUserToken>();

    public virtual ICollection<WsmartRole> Roles { get; set; } = new List<WsmartRole>();
}
