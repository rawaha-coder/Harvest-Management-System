using Harvest_Management_System.Database;
using Harvest_Management_System.Models;
using Harvest_Management_System.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Harvest_Management_System.Views
{
    public partial class FarmManager : Form
    {
        private FarmDAO farmDAO = FarmDAO.getInstance();
        List<Farm> listFarm = null;
        private bool editFarm = false;
        private Farm mFarm = null;

        public FarmManager()
        {
            InitializeComponent();
        }

        private void FarmManager_Load(object sender, EventArgs e)
        {
            listFarm = new List<Farm>();
            mFarm = new Farm();
            DisplayFarmData();
            ClearFields();
        }

        private void btnSaveFarm_Click(object sender, EventArgs e)
        {
            if (editFarm) { 
                EditFarm(); 
            }else { 
                AddFarm(); 
            }
            DisplayFarmData();
            ResetFields();
        }

        private void EditFarm()
        {
            if (txtFarmName.Text == "" || mFarm.Id <= 0)
            {
                MessageBox.Show("Vérifier les valeurs");
                return;
            }
            try
            {
                getFarmData();
                farmDAO.UpdateFarm(mFarm);
                MessageBox.Show("les informations sont mises à jour.", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Updated: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
        }

        private void AddFarm()
        {
            if (txtFarmName.Text == "")
            {
                MessageBox.Show("Vérifier les valeurs");
                return;
            }
            try
            {
                getFarmData();
                farmDAO.AddFarm(mFarm);
                MessageBox.Show("Les information été ajouté à la base de données", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Added: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

        }

        private void getFarmData()
        {
            mFarm.Name = txtFarmName.Text.Trim().ToUpper();
            mFarm.Address = txtFarmAddress.Text.Trim().ToUpper();
            mFarm.Area = (txtFarmArea.Text != "") ? Convert.ToDouble(txtFarmArea.Text) : 0.0;
            mFarm.PlantingDate = datePlantingDate.Value;
            mFarm.HarvestDate = dateHarvestDate.Value;
        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateNumberEntred(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ces données", "Supprimer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (editFarm) { DeleteFarm(); }
                DisplayFarmData();
                ResetFields();
            }
        }

        private void DeleteFarm()
        {
            if (txtFarmName.Text == "" || mFarm.Id <= 0)
            {
                MessageBox.Show("Select Farm required");
                return;
            }
            try { farmDAO.DeleteFarm(mFarm); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void DisplayFarmData()
        {
            try
            {
                listFarm = farmDAO.FarmList();
                FarmDataGridView.DataSource = listFarm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetFields()
        {
            btnSaveFarm.Text = "Ajouter";
            btnClearReset.Text = "Vider";
            btnDelete.Visible = false;
            editFarm = false;
            ClearFields();
        }

        private void ClearFields()
        {
            txtFarmName.Text = "";
            txtFarmAddress.Text = "";
            txtFarmArea.Text = "";
            datePlantingDate.Value = DateTime.Now;
            dateHarvestDate.Value = DateTime.Now;
        }

        private void FarmDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mFarm = listFarm[e.RowIndex];
                txtFarmName.Text = mFarm.Name;
                txtFarmAddress.Text = mFarm.Address;
                txtFarmArea.Text = mFarm.Area.ToString();
                datePlantingDate.Value = mFarm.PlantingDate;
                dateHarvestDate.Value = mFarm.HarvestDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ShowEditMode();
        }

        private void ShowEditMode()
        {
            editFarm = true;
            btnSaveFarm.Text = "Update";
            btnClearReset.Text = "Reset";
            btnDelete.Visible = true;
        }

        private void btnClearReset_Click(object sender, EventArgs e)
        {
            if (editFarm)
            {
                ResetFields();
            }
            else
            {
                ClearFields();
            }
        }
    }
}
