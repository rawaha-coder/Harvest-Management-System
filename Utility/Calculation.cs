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
        
        public static TotalCarrotHarvested calculTotal(List<HarvestCarrotProduct> carrotHarvestingList)
        {
            TotalCarrotHarvested totalCarrotHarvested = new TotalCarrotHarvested();
            foreach(HarvestCarrotProduct ch in carrotHarvestingList)
            {
                if (ch.EmployeeStatus)
                {
                    totalCarrotHarvested.TotalEmployee += 1;
                    totalCarrotHarvested.TotalQuantity[0] += ch.C0TQ;
                    totalCarrotHarvested.DamageQuantity[0] += ch.C0DQ;
                    totalCarrotHarvested.Charge[0] += ch.Charge;
                    totalCarrotHarvested.TotalQuantity[1] += ch.C1TQ;
                    totalCarrotHarvested.DamageQuantity[1] += ch.C1DQ;
                    totalCarrotHarvested.Charge[1] += ch.Charge;
                    totalCarrotHarvested.TotalQuantity[2] += ch.C2TQ;
                    totalCarrotHarvested.DamageQuantity[2] += ch.C2DQ;
                    totalCarrotHarvested.Charge[2] += ch.Charge;
                    totalCarrotHarvested.TotalQuantity[3] += ch.C3TQ;
                    totalCarrotHarvested.DamageQuantity[3] += ch.C3DQ;
                    totalCarrotHarvested.Charge[3] += ch.Charge;
                    totalCarrotHarvested.TotalQuantity[4] += ch.C4TQ;
                    totalCarrotHarvested.DamageQuantity[4] += ch.C4DQ;
                    totalCarrotHarvested.Charge[4] += ch.Charge;
                }

            }
            return totalCarrotHarvested;
        }
    }
}
