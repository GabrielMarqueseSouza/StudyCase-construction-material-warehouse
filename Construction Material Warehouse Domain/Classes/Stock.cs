using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockCategoryName { get; set; }
        public int StockProductId { get; set; }
        public int StockProductAmount { get; set; }
        public bool IsProductAvailable { get; set; }
        public Users SystemInclusionUser { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public int[] StockPermissionsIds { get; set; }
    }
}
