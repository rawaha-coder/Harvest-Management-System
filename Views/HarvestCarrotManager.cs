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

namespace Harvest_Management_System.Views
{
    public partial class HarvestCarrotManager : Form
    {
        List<CarrotHarvesting> carrotHarvestingList = new List<CarrotHarvesting>();
        public HarvestCarrotManager()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
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
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            List<CarrotHarvesting> importedList = new List<CarrotHarvesting>();
            try
            {
                importedList = ReaHarvestFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDGVData();
        }

        private List<CarrotHarvesting> ReaHarvestFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Office Files|*.xlsx;*.xls;", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    DataSet result = reader.AsDataSet();
                    DataTable tbl = result.Tables[0];

                    foreach (DataRow row in tbl.Rows)
                    {

                        if (row.ItemArray[0].ToString() == "ID") continue;

                        CarrotHarvesting carrotHarvesting = new CarrotHarvesting();
                        try
                        {
                            carrotHarvesting.Employee.EmployeeId = (row.ItemArray[0].ToString() != null && !row.ItemArray[0].ToString().Equals("")) ? Convert.ToInt32(row.ItemArray[0].ToString()) : -1;
                            carrotHarvesting.Employee.FirstName = row.ItemArray[1].ToString();


                            carrotHarvesting.HarvestCarrots[0].Harvest.TotalQuantity = (row.ItemArray[2].ToString() != null && !row.ItemArray[2].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[2].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[1].Harvest.TotalQuantity = (row.ItemArray[3].ToString() != null && !row.ItemArray[3].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[3].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[2].Harvest.TotalQuantity = (row.ItemArray[4].ToString() != null && !row.ItemArray[4].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[4].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[3].Harvest.TotalQuantity = (row.ItemArray[5].ToString() != null && !row.ItemArray[5].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[5].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[4].Harvest.TotalQuantity = (row.ItemArray[6].ToString() != null && !row.ItemArray[6].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[6].ToString()) : 0;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        carrotHarvestingList.Add(carrotHarvesting);
                    }
                    reader.Close();
                    fs.Close();
                }
            }
            return carrotHarvestingList;
        }

        private void loadDGVData()
        {
            try
            {
                dgvHarvestCarrot.DataSource = ReaHarvestFile();
            }
            catch(Exception ex)
            {
                Logging.LogError(ex);
            }
        }
    }
}
