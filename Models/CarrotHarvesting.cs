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

        public int EmployeeId
        {
            get => employee.EmployeeId;
        }

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

        public double C1DQ
        {
            get => harvestCarrots[0].Harvest.DamagedQuantity;
        }
        public double C2DQ
        {
            get => harvestCarrots[1].Harvest.DamagedQuantity;
        }
        public double C3DQ
        {
            get => harvestCarrots[2].Harvest.DamagedQuantity;
        }
        public double C4DQ
        {
            get => harvestCarrots[3].Harvest.DamagedQuantity;
        }

        public double C5DQ
        {
            get =>  harvestCarrots[4].Harvest.DamagedQuantity;
        }

        public double C1GQ
        {
            get => harvestCarrots[0].Harvest.TotalQuantity - harvestCarrots[0].Harvest.DamagedQuantity;
        }
        public double C2GQ
        {
            get => harvestCarrots[1].Harvest.TotalQuantity - harvestCarrots[1].Harvest.DamagedQuantity;
        }
        public double C3GQ
        {
            get => harvestCarrots[2].Harvest.TotalQuantity - harvestCarrots[2].Harvest.DamagedQuantity;
        }
        public double C4GQ
        {
            get => harvestCarrots[3].Harvest.TotalQuantity - harvestCarrots[3].Harvest.DamagedQuantity;
        }

        public double C5GQ
        {
            get => harvestCarrots[4].Harvest.TotalQuantity - harvestCarrots[4].Harvest.DamagedQuantity;
        }

        public double Quantity
        {
            get => totalQuantity();
        }

        private double totalQuantity()
        {
            double tQ = 0;
            double dQ = 0;
            for (int i = 0; i < HarvestCarrots.Length; i++)
            {
                tQ += harvestCarrots[i].Harvest.TotalQuantity;
                dQ += harvestCarrots[i].Harvest.DamagedQuantity;
            }
            return tQ - dQ;
        }

        public double Charge
        {
            get => totalCharge();
        }

        private double totalCharge()
        {
            double tC = 0;
            for (int i = 0; i < HarvestCarrots.Length; i++)
            {
                tC += (harvestCarrots[i].Harvest.TotalQuantity - harvestCarrots[i].Harvest.DamagedQuantity) * harvestCarrots[i].Carrot.EmployeePrice;
            }
            return (double)System.Math.Round(tC,2);
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
