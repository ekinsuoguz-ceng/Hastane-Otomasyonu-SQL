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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");

        private void HastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void HastaEklebtn1(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO hasta (hasta_adı, hasta_soyadı, tc_no, dogum_yeri, dogum_tarihi, medeni_durum, adres, telefon) values(@hasta_adı, @hasta_soyadı, @tc_no, @dogum_yeri, @dogum_tarihi, @medeni_durum, @adres,@telefon)", con);
            cmd.Parameters.AddWithValue("@hasta_adı", adtxt.Text);
            cmd.Parameters.AddWithValue("@hasta_soyadı", soyadtxt.Text);
            cmd.Parameters.AddWithValue("@tc_no", Convert.ToInt64(tctxt.Text));
            cmd.Parameters.AddWithValue("@dogum_yeri", yertxt.Text);
            cmd.Parameters.AddWithValue("@dogum_tarihi", DateTime.Parse(tarihtxt.Text));
            cmd.Parameters.AddWithValue("@medeni_durum", medeniDurumtxt.Text);
            cmd.Parameters.AddWithValue("@adres", adrestxt.Text);
            cmd.Parameters.AddWithValue("@telefon", Convert.ToInt64(telefontxt.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ekleme işlemi başarılı bir şekilde gerçekleşti");
            
        }
    }
}
