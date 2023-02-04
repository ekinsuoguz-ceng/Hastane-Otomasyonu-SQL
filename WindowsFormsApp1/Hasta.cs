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
    public class Hasta
    {
        public ulong TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Yer { get; set; }
        public string MedeniDurum { get; set; }
        public string Adres { get; set; }
        public ulong Telefon { get; set; }
    }
    }
