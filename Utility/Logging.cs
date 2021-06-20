using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harvest_Management_System.Utility
{
    class Logging
    {
        public static void LogError(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
