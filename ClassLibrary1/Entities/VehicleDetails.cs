using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBVehicleSystemWIthoutLogin.Shared.Entities
{
    public class VehicleDetails
    {
        public int Id { get; set; }
        public string? VehicleNo { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        public string? VehicleDepartment { get; set; }
        public bool IsVehicleReserved { get; set; } = false;
    }
}
