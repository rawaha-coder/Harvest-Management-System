using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class Product
    {
        private int id;
        private string name;
        private string code;
        private double employeePrice;
        private double companyPrice;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public double EmployeePrice { get => employeePrice; set => employeePrice = value; }
        public double CompanyPrice { get => companyPrice; set => companyPrice = value; }
    }
}
