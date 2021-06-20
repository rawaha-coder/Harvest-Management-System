using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Models
{
    class Employee
    {
        private int id;
        private bool status;
        private string firstName;
        private string lastName;
        private DateTime hireDate;
        private DateTime fireDate;
        private DateTime permitDate;

        public int EmployeeId { get => id; set => id = value; }
        public bool EmployeeStatus { get => status; set => status = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime HireDate { get => hireDate.Date; set => hireDate = value; }
        public DateTime FireDate { get => fireDate.Date; set => fireDate = value; }
        public DateTime PermitDate { get => permitDate.Date; set => permitDate = value; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
