using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class EmployeePermissions
    {
        public int PermissionId { get; set; }
        public string PermissionDescription { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
