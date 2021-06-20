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
        FarmDAO f = FarmDAO.getInstance();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            f.CreateTable();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
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

        private void btnProductManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductManager());
        }
    }
}
