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
        public static List<HarvestCarrot> readHarvestFile()
        {
            List<HarvestCarrot> HarvesterList = new List<HarvestCarrot>();
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
                        HarvestCarrot hq = new HarvestCarrot();
                        try
                        {
                            hq.Harvest.TotalQuantity = (row.ItemArray[7].ToString() != null && !row.ItemArray[7].ToString().Equals("")) ? Convert.ToDouble(row.ItemArray[7].ToString()) : 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        //if (hq.Harvest.TotalQuantity > 0 && hq.Employee.EmployeeId > 0) HarvesterList.Add(hq);
                    }
                    reader.Close();
                }
            }
            return HarvesterList;
        }

        public static bool ScrambledEquals(List<int> x, List<int> y)
        {
            return !x.Except(y).Any();
        }
    }
}
