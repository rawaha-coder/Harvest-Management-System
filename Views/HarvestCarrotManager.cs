using ExcelDataReader;
using Harvest_Management_System.Models;
using Harvest_Management_System.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harvest_Management_System.Database;

namespace Harvest_Management_System.Views
{
    public partial class HarvestCarrotManager : Form
    {
        private List<CarrotHarvesting> carrotHarvestingList = new List<CarrotHarvesting>();
        private TotalCarrotHarvested totalCarrotHarvested = new TotalCarrotHarvested();
        private SupplierDAO supplierDAO = SupplierDAO.getInstance();
        private FarmDAO farmDAO = FarmDAO.getInstance();
        private Dictionary<string, Supplier> mSupplierDictionary = new Dictionary<string, Supplier>();
        private Dictionary<string, Farm> mFarmDictionary = new Dictionary<string, Farm>();

        double test = 10;

        public HarvestCarrotManager()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void HarvestCarrotManager_Load(object sender, EventArgs e)
        {
            SortdgvHarvestCarrotColumnIndex();
            SupplierNameList();
            FarmNameList();
        }

        private void SupplierNameList()
        {
            List<string> NamesList = new List<string>();
            mSupplierDictionary.Clear();
            try
            {
                mSupplierDictionary = supplierDAO.SupplierDictionary();
                NamesList.AddRange(mSupplierDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                SupplierHarvestQuantityComboBox.DataSource = NamesList;
            }
        }

        private void FarmNameList()
        {
            List<string> NamesList = new List<string>();
            mFarmDictionary.Clear();
            try
            {
                mFarmDictionary = farmDAO.FarmDictionary();
                NamesList.AddRange(mFarmDictionary.Keys);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (NamesList != null)
            {
                FarmHarvestQuantityComboBox.DataSource = NamesList;
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                carrotHarvestingList = FileExcelReader.openExcelFile();
                dgvHarvestCarrot.DataSource = carrotHarvestingList;
                SortdgvHarvestCarrotColumnIndex();
            }
            catch (Exception ex)
            {
                Logging.LogError(ex);
            }
        }

        private void btnValidateHarvestQuantity_Click(object sender, EventArgs e)
        {
            totalCarrotHarvested = Calculation.calculTotal(carrotHarvestingList);
            setFieldsvalue();
        }

        private void setFieldsvalue()
        {
            txtTotalEmployee.Text = totalCarrotHarvested.TotalEmployee.ToString();
            txtC1TQ.Text = totalCarrotHarvested.TotalQuantity[0].ToString();
            txtC1DQ.Text = totalCarrotHarvested.DamageQuantity[0].ToString();
            txtC2TQ.Text = totalCarrotHarvested.TotalQuantity[1].ToString();
            txtC2DQ.Text = totalCarrotHarvested.DamageQuantity[1].ToString();
            txtC3TQ.Text = totalCarrotHarvested.TotalQuantity[2].ToString();
            txtC3DQ.Text = totalCarrotHarvested.DamageQuantity[2].ToString();
            txtC4TQ.Text = totalCarrotHarvested.TotalQuantity[3].ToString();
            txtC4DQ.Text = totalCarrotHarvested.DamageQuantity[3].ToString();
            txtC5TQ.Text = totalCarrotHarvested.TotalQuantity[4].ToString();
            txtC5DQ.Text = totalCarrotHarvested.DamageQuantity[4].ToString();
            txtQuantityTotal.Text = totalCarrotHarvested.SumQuantity.ToString();
        }

        private void SortdgvHarvestCarrotColumnIndex()
        {
            try
            {
                dgvHarvestCarrot.Columns["ColumnEmployeeId"].DisplayIndex = 0;
                dgvHarvestCarrot.Columns["ColumnEmployeeStatus"].DisplayIndex = 1;
                dgvHarvestCarrot.Columns["ColumnFullName"].DisplayIndex = 2;
                dgvHarvestCarrot.Columns["ColumnC1TQ"].DisplayIndex = 3;
                dgvHarvestCarrot.Columns["ColumnC1DQ"].DisplayIndex = 4;
                dgvHarvestCarrot.Columns["ColumnC2TQ"].DisplayIndex = 5;
                dgvHarvestCarrot.Columns["ColumnC2DQ"].DisplayIndex = 6;
                dgvHarvestCarrot.Columns["ColumnC3TQ"].DisplayIndex = 7;
                dgvHarvestCarrot.Columns["ColumnC3DQ"].DisplayIndex = 8;
                dgvHarvestCarrot.Columns["ColumnC4TQ"].DisplayIndex = 9;
                dgvHarvestCarrot.Columns["ColumnC4DQ"].DisplayIndex = 10;
                dgvHarvestCarrot.Columns["ColumnC5TQ"].DisplayIndex = 11;
                dgvHarvestCarrot.Columns["ColumnC5DQ"].DisplayIndex = 12;
                dgvHarvestCarrot.Columns["ColumnQuantity"].DisplayIndex = 13;
            }catch(Exception ex)
            {
                Logging.LogError(ex);
            }
        }

        private void dgvHarvestCarrot_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvHarvestCarrot.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.ColumnHeader)
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                foreach (DataGridViewColumn column in dgvHarvestCarrot.Columns)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = column.HeaderText;
                    item.Checked = column.Visible;
                    item.Click += (obj, ea) =>
                    {
                        column.Visible = !item.Checked;
                        item.Checked = column.Visible;
                        menuStrip.Show(dgvHarvestCarrot, e.Location);
                    };
                    menuStrip.Items.Add(item);
                }

                menuStrip.Show(dgvHarvestCarrot, e.Location);
            }
            SortdgvHarvestCarrotColumnIndex();
        }

    }
}
