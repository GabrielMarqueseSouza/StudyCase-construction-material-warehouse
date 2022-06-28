using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string SuppliedProduct { get; set; }
        public string SupplierContact { get; set; }
        public string Email { get; set; }
        public DateTime ProductRequestDate { get; set; }
        public string SupplierRegistryOfLegalEntities { get; set; }
        public bool IsProductDelivered { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
        public int[] SupplierPermissionIds { get; set; }
    }
}
