using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class CreditCardPayment : CardData
    {
        public Guid TransactionId { get; set; }
        public static PaymentMethods CardType => PaymentMethods.CreditCard;
        public int NumberOfInstallments { get; set; } //Qtd Parcelas
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}