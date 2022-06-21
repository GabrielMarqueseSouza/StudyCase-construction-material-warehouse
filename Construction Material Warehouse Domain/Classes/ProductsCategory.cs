using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class ProductsCategory
    {
        public int ProductCategoryId { get; set; }
        public Stock ProductStockId { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
        public int[] CategoryPermissionsIds { get; set; }
    }
}
