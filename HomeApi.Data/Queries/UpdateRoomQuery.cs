﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    public class UpdateRoomQuery
    {
        public string NewName { get; set; }
        public int NewArea { get; set; }
        public bool GasConnected { get; set; }
        public int NewVoltage { get; set; }

        public UpdateRoomQuery(string newName, int newArea, bool gasConnected, int newVoltage)
        {
            NewName = newName;
            NewArea = newArea;
            GasConnected = gasConnected;
            NewVoltage = newVoltage;
        }
    }
}
