using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class Harvest
    {
        private int id;
        private DateTime date;
        private Supplier supplier;
        private Farm farm;

        public Harvest()
        {
            Supplier = new Supplier();
            Farm = new Farm();
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date.Date; set => date = value; }
        internal Supplier Supplier { get => supplier; set => supplier = value; }
        internal Farm Farm { get => farm; set => farm = value; }
    }
}
