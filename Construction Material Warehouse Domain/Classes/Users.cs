using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Users
    {
        public Employees EmployeeId { get; set; }
        public string UserName { get; set; }
        public string UserContact { get; set; }
        public string Email { get; set; }
        public string AccessName { get; set; }
        public string PassWord { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public int UserIdSystemInclusion { get; set; }
        public int UserPermissions { get; set; }
    }
}
