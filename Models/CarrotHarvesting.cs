using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class CarrotHarvesting
    {
        private int id;
        private Employee employee = null;
        private HarvestCarrot[] harvestCarrots = null;

        public CarrotHarvesting()
        {
            Employee = new Employee();
            HarvestCarrots = new HarvestCarrot[5];
            initCarrotHarvesting();
        }

        internal Employee Employee { get => employee; set => employee = value; }
        internal HarvestCarrot[] HarvestCarrots { get => harvestCarrots; set => harvestCarrots = value; }

        public string FullName
        {
            get => employee.FullName;
        }

        public bool EmployeeStatus
        {
            get => employee.EmployeeStatus; set => employee.EmployeeStatus = value;
        }

        public double C1TQ
        {
            get => harvestCarrots[0].Harvest.TotalQuantity;
        }
        public double C2TQ
        {
            get => harvestCarrots[1].Harvest.TotalQuantity;
        }
        public double C3TQ
        {
            get => harvestCarrots[2].Harvest.TotalQuantity;
        }
        public double C4TQ
        {
            get => harvestCarrots[3].Harvest.TotalQuantity;
        }

        public double C5TQ
        {
            get => harvestCarrots[4].Harvest.TotalQuantity;
        }

        public double Quantity
        {
            get => totalQuantity();
        }

        private double totalQuantity()
        {
            double tQ = 0;
            for (int i = 0; i < HarvestCarrots.Length; i++)
            {
                tQ += harvestCarrots[i].Harvest.TotalQuantity;
            }
            return tQ;
        }

        private void initCarrotHarvesting()
        {
            for (int i = 0; i < HarvestCarrots.Length; i++)
            {
                HarvestCarrots[i] = new HarvestCarrot();
            }
        }
    }
}
