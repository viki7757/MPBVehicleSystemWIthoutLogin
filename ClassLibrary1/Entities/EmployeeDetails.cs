using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBVehicleSystemWIthoutLogin.Shared.Entities
{
    public class EmployeeDetails
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nationality { get; set; }
        public string? Department { get; set; }
        public string? Position { get; set; }
        public string? LicenseId { get; set; }
    }
}
