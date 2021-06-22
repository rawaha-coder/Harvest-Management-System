using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Utility
{
    class Calculation
    {
        
        public static TotalCarrotHarvested calculTotal(List<CarrotHarvesting> carrotHarvestingList)
        {
            TotalCarrotHarvested totalCarrotHarvested = new TotalCarrotHarvested();
            foreach(CarrotHarvesting ch in carrotHarvestingList)
            {
                if (ch.EmployeeStatus)
                {
                    totalCarrotHarvested.TotalEmployee += 1;
                    totalCarrotHarvested.TotalQuantity[0] += ch.C1TQ;
                    totalCarrotHarvested.DamageQuantity[0] += ch.C1DQ;
                    totalCarrotHarvested.TotalQuantity[1] += ch.C2TQ;
                    totalCarrotHarvested.DamageQuantity[1] += ch.C2DQ;
                    totalCarrotHarvested.TotalQuantity[2] += ch.C3TQ;
                    totalCarrotHarvested.DamageQuantity[2] += ch.C3DQ;
                    totalCarrotHarvested.TotalQuantity[3] += ch.C4TQ;
                    totalCarrotHarvested.DamageQuantity[3] += ch.C4DQ;
                    totalCarrotHarvested.TotalQuantity[4] += ch.C5TQ;
                    totalCarrotHarvested.DamageQuantity[4] += ch.C5DQ;
                }

            }
            return totalCarrotHarvested;
        }
    }
}
