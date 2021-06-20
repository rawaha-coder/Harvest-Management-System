using Harvest_Management_System.Database;
using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harvest_Management_System.Views
{
    public partial class SupplierManager : Form
    {
        private SupplierDAO supplierDAO = SupplierDAO.getInstance();
        List<Supplier> listSupplier = new List<Supplier>();
        private bool editSupplier = false;
        private Supplier mSupplier = new Supplier();

        public SupplierManager()
        {
            InitializeComponent();
        }

        private void SupplierManager_Load(object sender, EventArgs e)
        {
            DisplaySupplierData();
        }
        public void DisplaySupplierData()
        {
            try
            {
                listSupplier = supplierDAO.ListSupplier();
                SupplierDataGridView.DataSource = listSupplier;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            if (editSupplier) { 
                EditSupplier(); 
            }else { 
                AddSupplier(); 
            }
            DisplaySupplierData();
            ResetFields();
        }

        private void EditSupplier()
        {
            if (txtSupplierName.Text == "" || mSupplier.SupplierId <= 0)
            {
                MessageBox.Show("Vérifier les valeurs");
                return;
            }
            try
            {
                getSupplierData();
                supplierDAO.UpdateSupplier(mSupplier);
                MessageBox.Show("les informations sont mises à jour.", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Updated: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void getSupplierData()
        {
            mSupplier.SupplierStatus = checkSupplierStatus.Checked;
            mSupplier.SupplierName = txtSupplierName.Text.Trim().ToUpper();
            mSupplier.SupplierFirstName = txtSupplierFirstName.Text.Trim().ToUpper();
            mSupplier.SupplierLastName = txtSupplierLastName.Text.Trim().ToUpper();
        }

        private void AddSupplier()
        {
            if (CheckInput())
            {
                MessageBox.Show("Vérifier les valeurs");
                return;
            }
            try
            {
                getSupplierData();
                supplierDAO.AddSupplier(mSupplier);
                MessageBox.Show("les informations sont mises à jour.", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Updated: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private bool CheckInput()
        {
            nameSupplierErrorLabel.Visible = (txtSupplierName.Text == "") ? true : false;
            supplierFirstNameErrorLabel.Visible = (txtSupplierFirstName.Text == "") ? true : false;
            supplierLastNameErrorLabel.Visible = (txtSupplierLastName.Text == "") ? true : false;
            return nameSupplierErrorLabel.Visible || supplierFirstNameErrorLabel.Visible || supplierLastNameErrorLabel.Visible;
        }

        private void btnClearReset_Click(object sender, EventArgs e)
        {
            if (editSupplier) { ResetFields(); } else { ClearFields(); }
        }

        private void ResetFields()
        {
            btnSaveSupplier.Text = "Ajouter";
            btnClearReset.Text = "Vider";
            btnDelete.Visible = false;
            editSupplier = false;
            ClearFields();
        }

        private void ClearFields()
        {
            txtSupplierName.Text = "";
            txtSupplierFirstName.Text = "";
            txtSupplierLastName.Text = "";
            checkSupplierStatus.Checked = false;
        }

        private void SupplierDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mSupplier = listSupplier[e.RowIndex];
                checkSupplierStatus.Checked = mSupplier.SupplierStatus;
                txtSupplierName.Text = mSupplier.SupplierName;
                txtSupplierFirstName.Text = mSupplier.SupplierFirstName;
                txtSupplierLastName.Text = mSupplier.SupplierLastName;
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
            editSupplier = true;
            btnSaveSupplier.Text = "Update";
            btnClearReset.Text = "Reset";
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ces données", "Supprimer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (editSupplier) { DeleteSupplier(); }
                DisplaySupplierData();
                ResetFields();
            }
        }

        private void DeleteSupplier()
        {
            if (txtSupplierName.Text == "" || mSupplier.SupplierId <= 0)
            {
                MessageBox.Show("Vérifier les valeurs");
                return;
            }
            try { supplierDAO.DeleteSupplier(mSupplier); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
