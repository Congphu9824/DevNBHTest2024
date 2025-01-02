using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class CategoryWarehose
    {
        public string CodeWarehose { get; set; }
        public string? NameWarehose { get; set; }
        public string? AddressWarehose { get; set; }
        public string? CodeStocker { get; set; }
        public string? NameStocker { get; set; }
        public bool? CostPrice { get; set; }
        public bool IsStore { get; set; }
        public bool IsActive { get; set; }
        public string? Notes { get; set; }
        public Guid Id { get; set; }
        public int IdAsc { get; set; }
        public int CodeUnit { get; set; }
        public int? IdInv { get; set; }
        public string? CodeInv { get; set; }
        public string? NameInv { get; set; }
        public string? Branch { get; set; }
        public string? InvoiceTemplate { get; set; }
        public string? InvoiceSymbol { get; set; }
        public bool TaxSeparation { get; set; }
        public bool NotBog { get; set; }
        public bool NotEnviroment { get; set; }
        public bool AutoPublish { get; set; }
        public string? ServiceProfile { get; set; }
        public string? FristCode { get; set; }
        public string? BankOfAccount { get; set; }
        public string? BankOfName { get; set; }
        public string? BankCode { get; set; }
    }
}
