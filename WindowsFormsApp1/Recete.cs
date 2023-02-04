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
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");

        private void ReceteOlustur(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hastatctxt.Text))
            {
                MessageBox.Show("Hasta Tc Boş");
            }
            else
            {
                NpgsqlCommand s = new NpgsqlCommand();
                string komut = "SELECT COUNT(*) FROM hasta where tc_no =@tc";
                NpgsqlCommand da = new NpgsqlCommand(komut, con);
                con.Open();
                da.Parameters.AddWithValue("@tc", Convert.ToInt64( hastatctxt.Text));
                long sonuc = Convert.ToInt64(da.ExecuteScalar());

                if (sonuc > 0)
                {               
                    
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO recete (ilac_barkod,tc_no) values (@ilac_barkod,@tc_no)", con);

                    cmd.Parameters.AddWithValue("@ilac_barkod", Convert.ToInt64(ilacbarkodtxt.Text));
                    cmd.Parameters.AddWithValue("@tc_no", Convert.ToInt64(hastatctxt.Text));
                    cmd.ExecuteNonQuery();

                    con.Close();

                        MessageBox.Show("Reçete oluşturuldu.");        
                }
            }

            string sorgu = "SELECT r.ilac_barkod, r.tc_no, m.muayene_tarihi FROM recete r INNER JOIN muayene m ON r.tc_no = m.tc_no where r.tc_no = '" + hastatctxt.Text + "'ORDER BY muayene_tarihi ASC";
            NpgsqlDataAdapter dta = new NpgsqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            dta.Fill(ds);
            HastaİlacList.DataSource = ds.Tables[0];
        }

        private void Recete_Load(object sender, EventArgs e)
        {

        }
    }
}
