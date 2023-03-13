using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models.Rooms
{
    public class EditRoomRequest
    {
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string NewName { get; set; }
        public int NewArea { get; set; }
        public bool GasConnected { get; set; }
        public int NewVoltage { get; set; }
    }
}
