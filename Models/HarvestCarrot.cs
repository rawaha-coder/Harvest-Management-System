using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class HarvestCarrot
    {
        Harvest harvest;
        Carrot carrot;

        public HarvestCarrot()
        {
            harvest = new Harvest();
            carrot = new Carrot();
        }

        internal Harvest Harvest { get => harvest;}
        internal Carrot Carrot { get => carrot;}
    }
}
