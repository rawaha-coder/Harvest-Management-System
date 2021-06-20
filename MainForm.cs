using Harvest_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harvest_Management_System.Models;
using Harvest_Management_System.Utility;
using Harvest_Management_System.Views;

namespace Harvest_Management_System
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        CarrotDAO c = CarrotDAO.getInstance();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            insertIntoDatabase();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void insertIntoDatabase()
        {



            //Carrot carrrot = new Carrot();
            //carrrot.Type = 2;
            //carrrot.Name = "TGR SW";
            //carrrot.Code = "C5";
            //carrrot.EmployeePrice = 0.1;
            //carrrot.CompanyPrice = 0.2;
            //try
            //{
            //    c.addNewProduct(carrrot);
            //}catch(Exception ex)
            //{
            //    Logging.LogError(ex);
            //}

        }

        private void btnEmployeeManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeManager());
        }

        private void btnFarmManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FarmManager());
        }

        private void btnSupplierManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierManager());
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }
    }
}
