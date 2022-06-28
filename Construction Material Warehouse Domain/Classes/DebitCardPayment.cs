using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class DebitCardPayment : CardData
    {
        public Guid TransactionId { get; set; }
        public static PaymentMethods CardType => PaymentMethods.DebitCard;
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
