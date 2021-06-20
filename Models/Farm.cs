using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class Farm
    {
        private int id;
        private string name;
        private string address;
        private double area;
        private DateTime plantingDate;
        private DateTime harvestDate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public DateTime PlantingDate { get => plantingDate.Date; set => plantingDate = value; }
        public DateTime HarvestDate { get => harvestDate.Date; set => harvestDate = value; }
        public double Area { get => area; set => area = value; }
    }
}
