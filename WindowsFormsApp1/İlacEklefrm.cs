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
    public partial class İlacEklefrm : Form
    {
        public İlacEklefrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");
       
        private void İlaceklebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO ilac (barkod_no, ilac_adı, ilac_tipi) values(@barkod_no, @ilac_adı, @ilac_tipi)", con);
           
            cmd.Parameters.AddWithValue("@barkod_no", Convert.ToInt64(barkodtxt.Text));
            cmd.Parameters.AddWithValue("@ilac_adı", ilacadtxt.Text);
            cmd.Parameters.AddWithValue("@ilac_tipi", ilactiptxt.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("İlaç ekleme işlemi başarılı bir şekilde gerçekleşti");
           
           
        }

        private void ilaclistelebtn(object sender, EventArgs e)
        {
            string sorgu = "SELECT * from ilac ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ilaceklelist.DataSource = ds.Tables[0];
        }
    }
}
