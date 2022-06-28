using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Payment
    {
        public Guid TransactionId { get; set; }
        public decimal PaymentAmount { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsPaymentSuccessful { get; set; }
        public Clients Buyer { get; set; }
        public Employees SalespersonRegistry { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
