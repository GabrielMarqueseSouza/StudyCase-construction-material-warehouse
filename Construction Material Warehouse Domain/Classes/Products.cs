using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public ProductsCategory ProductCategory { get; set; }
        public ProductsCategory ProductCategoryId { get; set; }
        public Stock StockQuantity { get; set; }
        public double ProductPrice { get; set; }
        public bool HaveDiscount { get; set; }
        public int? DiscountAmount { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
        public int[] ProductPermissionsIds { get; set; } //Quais funcionários/usuários podem alterar informações do produto
    }
}
