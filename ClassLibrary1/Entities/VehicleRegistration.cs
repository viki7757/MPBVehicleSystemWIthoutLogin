using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBVehicleSystemWIthoutLogin.Shared.Entities
{
    public class VehicleRegistration
    {
        public int Id { get; set; }
        public string? VehicleNo { get; set; }
        public string? Brand { get; set; }
        public string? Type { get; set; }
        public string? Department { get; set; }
        public string? Location { get; set; }
        public bool IsVehicleReserved { get; set; } = false;
        public bool IsRecordDelete { get; set; } = false;
    }
}
