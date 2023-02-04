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
    public partial class Hasta_Listele : Form
    {
        public Hasta_Listele()
        {
            InitializeComponent();
        }

        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");


        private void listelebuton2(object sender, EventArgs e)
        {
            string sorgu = "SELECT * from hasta ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
