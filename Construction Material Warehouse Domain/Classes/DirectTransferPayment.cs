using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class DirectTransferPayment
    {
        public Guid TransactionId { get; set; }
        public static PaymentMethods Payment => PaymentMethods.DirectTransfer;
        public string BuyerRegistryOfLegalPersonOrEntity { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
