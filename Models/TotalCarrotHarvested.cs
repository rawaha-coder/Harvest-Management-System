using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class TotalCarrotHarvested
    {
        private int totalEmployee = 0;
        private double[] totalQuantity = new double[5];
        private double[] damageQuantity = new double[5];
        private double[] goodQuantity = new double[5];
        private double[] charge = new double[5];

        public int TotalEmployee { get => totalEmployee; set => totalEmployee = value; }
        public double[] TotalQuantity { get => totalQuantity; set => totalQuantity = value; }
        public double[] DamageQuantity { get => damageQuantity; set => damageQuantity = value; }
        public double[] GoodQuantity { get => goodQuantity; set => goodQuantity = value; }
        public double[] Charge { get => charge; set => charge = value; }

        public double Payment()
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Charge[i];
            }
            return (double)System.Math.Round(sum, 2);
        }
        public double SumQuantity { get => CalculSum(); }

        private double CalculSum()
        {
            double sum = 0;
            for (int i=0; i < 5; i++)
            {
                sum += TotalQuantity[i] - DamageQuantity[i];
            }
            return sum;
        }
    }
}
