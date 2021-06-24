using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class HarvestProduct
    {
        private double totalQuantity;
        private double damagedQuantity;

        public double TotalQuantity { get => totalQuantity; set => totalQuantity = value; }
        public double DamagedQuantity { get => damagedQuantity; set => damagedQuantity = value; }

    }
}
