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
    public class Muayene
    {
        public ulong TCKimlikNo { get; set; }
        public DateTime MuayeneTarihi { get; set; }
        public string HastaninSikayeti { get; set; }
        public string OnerilenTedavi { get; set; }
        public ulong ReceteNo { get; set; }
    }
}
