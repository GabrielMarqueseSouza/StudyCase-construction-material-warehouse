using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class MoneyPayment
    {
        public Guid TransactionId { get; set; }
        public static PaymentMethods Money => PaymentMethods.Money;
        public string BuyerName { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
