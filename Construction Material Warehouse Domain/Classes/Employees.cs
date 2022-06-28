using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Employees
    {
        public Guid EmployeeId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public string EmpLegalRegistry { get; set; }
        public string EmpAddress { get; set; }
        public string ZipCode { get; set; }
        public string EmpContact { get; set; }
        public string EmpEmail { get; set; }
        public double EmpSalary { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DemissionDate { get; set; }
        public bool IsOrIsNotAdministrator { get; set; }
        public string EmpPosition { get; set; }
        public EmployeePermissions EmpPermissions { get; set; }
        public string EmpAccessName { get; set; }
        public string EmpPassword { get; set; }
        public DateTime SystemInclusionDate { get; set; }
        public Users SystemInclusionUser { get; set; }
    }
}
