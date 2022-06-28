using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Invoices
    {
        public int InvoiceId { get; set; }
        public int InvoiceNumber { get; set; }
        public string? InvoiceSerialNumber { get; set; }
        public string? InvoiceKeyNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public Clients Client { get; set; }
        public decimal InvoiceValue { get; set; }
        public bool IsInvoiceCancelled { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
