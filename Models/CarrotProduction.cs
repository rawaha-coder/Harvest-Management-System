using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class CarrotProduction : HarvestCarrotProduct
    {
        private int id;
        private Harvest harvest;

        public CarrotProduction()
        {
            Harvest = new Harvest();
        }

        public int Id { get => id; set => id = value; }
        internal Harvest Harvest { get => harvest; set => harvest = value; }
    }
}
