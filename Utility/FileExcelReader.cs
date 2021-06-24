using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ExcelDataReader;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Harvest_Management_System.Utility
{
    class FileExcelReader
    {
        private static List<HarvestCarrotProduct> carrotHarvestingList = new List<HarvestCarrotProduct>();
        private static OpenFileDialog openFileDialogForExcel = new OpenFileDialog();
        public static List<HarvestCarrotProduct> openExcelFile()
        {
            openFileDialogForExcel.Reset();
            openFileDialogForExcel.Filter = "Office files(*.xlsx;*.xls)|*.xlsx;*.xls| All files(*.*)|*.*";
            openFileDialogForExcel.FilterIndex = 1;
            openFileDialogForExcel.RestoreDirectory = true;
            carrotHarvestingList.Clear();
            if (openFileDialogForExcel.ShowDialog() == DialogResult.OK)
            {
                readExcelFile(openFileDialogForExcel.FileName);
            }
            return carrotHarvestingList;
        }

        public static void readExcelFile(string filePath)
        {

                    FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    DataSet result = reader.AsDataSet();
                    DataTable tbl = result.Tables[0];

                    foreach (DataRow row in tbl.Rows)
                    {

                        if (row.ItemArray[0].ToString() == "ID") continue;

                        HarvestCarrotProduct carrotHarvesting = new HarvestCarrotProduct();
                        try
                        {
                            carrotHarvesting.Employee.EmployeeId = (row.ItemArray[0].ToString() != null && !row.ItemArray[0].ToString().Equals("")) ? Convert.ToInt32(row.ItemArray[0].ToString()) : -1;
                            carrotHarvesting.Employee.FirstName = row.ItemArray[1].ToString();

                            carrotHarvesting.HarvestCarrots[0].Product.TotalQuantity = (row.ItemArray[2].ToString() != null && !row.ItemArray[2].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[2].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[1].Product.TotalQuantity = (row.ItemArray[3].ToString() != null && !row.ItemArray[3].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[3].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[2].Product.TotalQuantity = (row.ItemArray[4].ToString() != null && !row.ItemArray[4].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[4].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[3].Product.TotalQuantity = (row.ItemArray[5].ToString() != null && !row.ItemArray[5].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[5].ToString()) : 0;

                            carrotHarvesting.HarvestCarrots[4].Product.TotalQuantity = (row.ItemArray[6].ToString() != null && !row.ItemArray[6].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[6].ToString()) : 0;

                            carrotHarvesting.EmployeeStatus = (carrotHarvesting.Quantity > 0) ? true : false;

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

        public static bool ScrambledEquals(List<int> x, List<int> y)
        {
            return !x.Except(y).Any();
        }
    }
}
