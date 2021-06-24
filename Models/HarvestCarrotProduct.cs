using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class HarvestCarrotProduct
    {

        private Employee employee;
        private HarvestCarrot[] harvestCarrots;

        public HarvestCarrotProduct()
        {
            Employee = new Employee();
            HarvestCarrots = new HarvestCarrot[5];
            initCarrotHarvesting();
        }

        internal Employee Employee { get => employee; set => employee = value; }
        internal HarvestCarrot[] HarvestCarrots { get => harvestCarrots; set => harvestCarrots = value; }

        public int EmployeeId
        {
            get => employee.EmployeeId; set => employee.EmployeeId = value;
        }

        public string FullName
        {
            get => employee.FullName;
        }

        public bool EmployeeStatus
        {
            get => employee.EmployeeStatus; set => employee.EmployeeStatus = value;
        }

        public double C0TQ
        {
            get => harvestCarrots[0].Product.TotalQuantity; set => harvestCarrots[0].Product.TotalQuantity = value;
        }
        public double C1TQ
        {
            get => harvestCarrots[1].Product.TotalQuantity; set => harvestCarrots[1].Product.TotalQuantity = value;
        }
        public double C2TQ
        {
            get => harvestCarrots[2].Product.TotalQuantity; set => harvestCarrots[2].Product.TotalQuantity = value;
        }
        public double C3TQ
        {
            get => harvestCarrots[3].Product.TotalQuantity; set => harvestCarrots[3].Product.TotalQuantity = value;
        }

        public double C4TQ
        {
            get => harvestCarrots[4].Product.TotalQuantity; set => harvestCarrots[4].Product.TotalQuantity = value;
        }

        public double C0DQ
        {
            get => harvestCarrots[0].Product.DamagedQuantity; set => harvestCarrots[0].Product.DamagedQuantity = value;
        }
        public double C1DQ
        {
            get => harvestCarrots[1].Product.DamagedQuantity; set => harvestCarrots[1].Product.DamagedQuantity = value;
        }
        public double C2DQ
        {
            get => harvestCarrots[2].Product.DamagedQuantity; set => harvestCarrots[2].Product.DamagedQuantity = value;
        }
        public double C3DQ
        {
            get => harvestCarrots[3].Product.DamagedQuantity; set => harvestCarrots[3].Product.DamagedQuantity = value;
        }

        public double C4DQ
        {
            get =>  harvestCarrots[4].Product.DamagedQuantity; set => harvestCarrots[4].Product.DamagedQuantity = value;
        }

        public double C0GQ
        {
            get => harvestCarrots[0].Product.TotalQuantity - harvestCarrots[0].Product.DamagedQuantity;
        }
        public double C1GQ
        {
            get => harvestCarrots[1].Product.TotalQuantity - harvestCarrots[1].Product.DamagedQuantity;
        }
        public double C2GQ
        {
            get => harvestCarrots[2].Product.TotalQuantity - harvestCarrots[2].Product.DamagedQuantity;
        }
        public double C3GQ
        {
            get => harvestCarrots[3].Product.TotalQuantity - harvestCarrots[3].Product.DamagedQuantity;
        }

        public double C4GQ
        {
            get => harvestCarrots[4].Product.TotalQuantity - harvestCarrots[4].Product.DamagedQuantity;
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
                tQ += harvestCarrots[i].Product.TotalQuantity;
                dQ += harvestCarrots[i].Product.DamagedQuantity;
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
                tC += (harvestCarrots[i].Product.TotalQuantity - harvestCarrots[i].Product.DamagedQuantity) * harvestCarrots[i].Carrot.EmployeePrice;
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
