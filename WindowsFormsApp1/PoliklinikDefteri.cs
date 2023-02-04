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
    public partial class PoliklinikDefteri : Form
    {
        public PoliklinikDefteri()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void listelebuton1(object sender, EventArgs e)
        {

            string sorgu = "SELECT m.muayene_tarihi,h.hasta_adı, h.hasta_soyadı, h.dogum_tarihi, h.dogum_yeri, m.hasta_sikayeti, m.onerilen_tedavi FROM hasta h INNER JOIN muayene m ON h.tc_no = m.tc_no ORDER BY muayene_tarihi ASC ";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
    }
}
