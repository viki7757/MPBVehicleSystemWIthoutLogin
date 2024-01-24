using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBVehicleSystemWIthoutLogin.Shared.Entities
{
    public class EmployeeDetail
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? HHEmployeeNo { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? LHSEmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? Nationality { get; set; }
        public string? Department { get; set; }
        public string? Position { get; set; }
        public string? SiteLocation { get; set; }
        public string? LicenseId { get; set; } = null;
    }
}
