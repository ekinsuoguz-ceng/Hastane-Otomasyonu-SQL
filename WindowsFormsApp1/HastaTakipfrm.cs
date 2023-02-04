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
    public partial class HastaTakipfrm : Form
    {
        public HastaTakipfrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");
        DataSet dtst = new DataSet();//datagridviewlere sql serverdaki tabloları aktarmak için kullanıyoruz.
        private void HastailacListe(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("SELECT i.ilac_tipi,i.barkod_no,i.ilac_adı FROM hasta h INNER JOIN recete r ON h.tc_no = r.tc_no INNER JOIN ilac i ON r.ilac_barkod = i.barkod_no WHERE h.tc_no = '" + tctxt.Text + "'", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            da.Fill(ds);
            HastaİlacList.DataSource = ds.Tables[0];
            con.Close();

       

        }

        private void HastaHastalıkListe(object sender, EventArgs e)
        {

        }
    }
}
