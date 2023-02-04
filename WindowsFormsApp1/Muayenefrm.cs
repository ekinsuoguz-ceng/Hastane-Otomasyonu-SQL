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
    public partial class Muayenefrm : Form
    {
        public Muayenefrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");

        private void MuayeneEklebtn(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO muayene (tc_no,muayene_tarihi, hasta_sikayeti, onerilen_tedavi) values(@tc_no, @muayene_tarihi, @hasta_sikayeti, @onerilen_tedavi)", con);
            
            cmd.Parameters.AddWithValue("@tc_no", Convert.ToInt64(hastatctxt2.Text));
            cmd.Parameters.AddWithValue("@muayene_tarihi", DateTime.Parse(Mtarihtxt.Text));
            cmd.Parameters.AddWithValue("@hasta_sikayeti", hastaSikayet.Text);
            cmd.Parameters.AddWithValue("@onerilen_tedavi", tedavitx.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ekleme işlemi başarılı bir şekilde gerçekleşti");

        }

        private void Mtarihtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
