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
    public partial class İlacTakipfrm : Form
    {
        public İlacTakipfrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");
        DataSet dtst = new DataSet();//datagridviewlere sql serverdaki tabloları aktarmak için kullanıyoruz.
        private void HastaListbtn(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand sorgu = new NpgsqlCommand("SELECT h.hasta_adı, h.hasta_soyadı, r.ilac_barkod, r.tc_no FROM recete r INNER JOIN hasta h ON r.tc_no = h.tc_no WHERE r.ilac_barkod = '" + barkodtxt.Text + "'", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            da.Fill(ds);
            HastaİlacList.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
