﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class Farm
    {
        private int farmId;
        private string farmName;
        private string farmAddress;

        public int FarmId { get => farmId; set => farmId = value; }
        public string FarmName { get => farmName; set => farmName = value; }
        public string FarmAddress { get => farmAddress; set => farmAddress = value; }
    }
}
