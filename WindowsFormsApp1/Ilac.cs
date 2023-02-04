using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace WindowsFormsApp1
{
    public class Ilac
    {
        
        public ulong BarkodNo { get; set; }
        public string Ad { get; set; }
        public string Tip { get; set; }
    }
}
