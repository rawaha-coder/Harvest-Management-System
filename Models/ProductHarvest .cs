using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class ProductHarvest
    {
        Harvest harvest;
        Product product;

        public ProductHarvest()
        {
            Harvest = new Harvest();
            Product = new Product();
        }

        internal Harvest Harvest { get => harvest; set => harvest = value; }
        internal Product Product { get => product; set => product = value; }
    }
}
