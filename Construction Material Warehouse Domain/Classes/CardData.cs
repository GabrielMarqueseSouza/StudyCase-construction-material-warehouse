using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class CardData
    {
        public int CardNumber { get; set; }
        public string ClientName { get; set; }
        public bool HasClientRecord { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
