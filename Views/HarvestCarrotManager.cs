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
        private List<HarvestCarrotProduct> carrotHarvestingList = new List<HarvestCarrotProduct>();
        private TotalCarrotHarvested totalCarrotHarvested = new TotalCarrotHarvested();
        private SupplierDAO supplierDAO = SupplierDAO.getInstance();
        private FarmDAO farmDAO = FarmDAO.getInstance();
        private Dictionary<string, Supplier> mSupplierDictionary = new Dictionary<string, Supplier>();
        private Dictionary<string, Farm> mFarmDictionary = new Dictionary<string, Farm>();
        Carrot[] carrots = null;
        List<Carrot> carrotList = null;
        CarrotDAO carrotDAO = null;

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
                openExcelFile();
            }
            catch (Exception ex)
            {
                Logging.LogError(ex);
            }
        }

        private void openExcelFile()
        {
            carrotHarvestingList = FileExcelReader.openExcelFile();
            dgvHarvestCarrot.DataSource = carrotHarvestingList;
            SortdgvHarvestCarrotColumnIndex();
        }

        private void btnValidateHarvestQuantity_Click(object sender, EventArgs e)
        {
            loadCarrotPrice();
            getCarrotPrice();
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
            txtChargeTotal.Text = totalCarrotHarvested.Payment().ToString();
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
                dgvHarvestCarrot.Columns["ColumnC1GQ"].DisplayIndex = 5;
                dgvHarvestCarrot.Columns["ColumnC2TQ"].DisplayIndex = 6;
                dgvHarvestCarrot.Columns["ColumnC2DQ"].DisplayIndex = 7;
                dgvHarvestCarrot.Columns["ColumnC2GQ"].DisplayIndex = 8;
                dgvHarvestCarrot.Columns["ColumnC3TQ"].DisplayIndex = 9;
                dgvHarvestCarrot.Columns["ColumnC3DQ"].DisplayIndex = 10;
                dgvHarvestCarrot.Columns["ColumnC3GQ"].DisplayIndex = 11;
                dgvHarvestCarrot.Columns["ColumnC4TQ"].DisplayIndex = 12;
                dgvHarvestCarrot.Columns["ColumnC4DQ"].DisplayIndex = 13;
                dgvHarvestCarrot.Columns["ColumnC4GQ"].DisplayIndex = 14;
                dgvHarvestCarrot.Columns["ColumnC5TQ"].DisplayIndex = 15;
                dgvHarvestCarrot.Columns["ColumnC5DQ"].DisplayIndex = 16;
                dgvHarvestCarrot.Columns["ColumnC5GQ"].DisplayIndex = 17;
                dgvHarvestCarrot.Columns["ColumnQuantity"].DisplayIndex = 18;
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


        private void loadCarrotPrice()
        {

            carrots = new Carrot[11];
            carrotList = new List<Carrot>();
            carrotDAO = CarrotDAO.getInstance();
            initCarrotArray();
            GetCarrotList();
            SetCarrotArray();
        }
        private void initCarrotArray()
        {
            for (int i = 0; i < carrots.Length; i++)
                carrots[i] = new Carrot();
        }

        private void GetCarrotList()
        {
            try
            {
                carrotList.Clear();
                carrotList = carrotDAO.CarrotList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetCarrotArray()
        {
            if (carrotList.Count > 0)
            {
                foreach (Carrot carrot in carrotList)
                {
                    carrots[carrot.Id] = carrot;
                }
            }
        }

        private void getCarrotPrice()
        {
            if (radioOpen.Checked)
            {
                foreach(HarvestCarrotProduct ch in carrotHarvestingList)
                {
                    ch.HarvestCarrots[0].Carrot.EmployeePrice = carrots[1].EmployeePrice;
                    ch.HarvestCarrots[0].Carrot.CompanyPrice = carrots[1].CompanyPrice;
                    ch.HarvestCarrots[1].Carrot.EmployeePrice = carrots[2].EmployeePrice;
                    ch.HarvestCarrots[1].Carrot.CompanyPrice = carrots[2].CompanyPrice;
                    ch.HarvestCarrots[2].Carrot.EmployeePrice = carrots[3].EmployeePrice;
                    ch.HarvestCarrots[2].Carrot.CompanyPrice = carrots[3].CompanyPrice;
                    ch.HarvestCarrots[3].Carrot.EmployeePrice = carrots[4].EmployeePrice;
                    ch.HarvestCarrots[3].Carrot.CompanyPrice = carrots[4].CompanyPrice;
                    ch.HarvestCarrots[4].Carrot.EmployeePrice = carrots[5].EmployeePrice;
                    ch.HarvestCarrots[4].Carrot.CompanyPrice = carrots[5].CompanyPrice;
                }
            }
            if (radioTunnel.Checked)
            {
                foreach (HarvestCarrotProduct ch in carrotHarvestingList)
                {
                    ch.HarvestCarrots[0].Carrot.EmployeePrice = carrots[6].EmployeePrice;
                    ch.HarvestCarrots[0].Carrot.CompanyPrice = carrots[6].CompanyPrice;
                    ch.HarvestCarrots[1].Carrot.EmployeePrice = carrots[7].EmployeePrice;
                    ch.HarvestCarrots[1].Carrot.CompanyPrice = carrots[7].CompanyPrice;
                    ch.HarvestCarrots[2].Carrot.EmployeePrice = carrots[8].EmployeePrice;
                    ch.HarvestCarrots[2].Carrot.CompanyPrice = carrots[8].CompanyPrice;
                    ch.HarvestCarrots[3].Carrot.EmployeePrice = carrots[9].EmployeePrice;
                    ch.HarvestCarrots[3].Carrot.CompanyPrice = carrots[9].CompanyPrice;
                    ch.HarvestCarrots[4].Carrot.EmployeePrice = carrots[10].EmployeePrice;
                    ch.HarvestCarrots[4].Carrot.CompanyPrice = carrots[10].CompanyPrice;
                }
            }
        }

        private void btnApplyCarrotProduction_Click(object sender, EventArgs e)
        {

        }
    }
}
