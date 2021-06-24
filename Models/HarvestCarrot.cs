using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class HarvestCarrot
    {
        HarvestProduct product;
        Carrot carrot;

        public HarvestCarrot()
        {
            product = new HarvestProduct();
            carrot = new Carrot();
        }

        internal HarvestProduct Product { get => product;}
        internal Carrot Carrot { get => carrot;}
    }
}
