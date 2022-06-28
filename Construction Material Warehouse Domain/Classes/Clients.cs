using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Clients
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string ClientRegistryOfLegalPersonOrEntity { get; set; }
        public bool IsActive { get; set; }
        public bool HaveDiscount { get; set; }
        public int? PurchaseQuantity { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Payment PaymentMethod { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
