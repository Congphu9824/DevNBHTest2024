using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartInfoPaymentBill
{
    public Guid Id { get; set; }

    /// <summary>
    /// ID hóa đơn bán hàng
    /// </summary>
    public Guid? IdInv { get; set; }

    /// <summary>
    /// Id bill thanh toán có chiều dài 7 ký tự sinh nhẫu nhiên không trùng
    /// </summary>
    public string? BillId { get; set; }

    public decimal? Amount { get; set; }

    public string? StaffCode { get; set; }

    /// <summary>
    /// Trạng thái đã thanh toán hay chưa thanh toán
    /// </summary>
    public bool StatusPayment { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Notes { get; set; }

    /// <summary>
    /// Trạng thái hiệu lực của bill hàng, còn giá trị thanh toán hay không
    /// </summary>
    public bool StillValid { get; set; }

    public int? CodeUnit { get; set; }

    public int IdAsc { get; set; }
}
