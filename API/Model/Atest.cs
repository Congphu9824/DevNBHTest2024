using System;
using System.Collections.Generic;

namespace API.Model;

public partial class Atest
{
    /// <summary>
    /// Khóa
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Họ
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Tên
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Ngày sinh
    /// </summary>
    public DateOnly? Birthday { get; set; }

    /// <summary>
    /// Ngày Tạo
    /// </summary>
    public DateTime? CreatedDate { get; set; }
}
