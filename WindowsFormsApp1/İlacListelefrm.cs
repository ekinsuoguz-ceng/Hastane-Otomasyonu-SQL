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
    public partial class İlacListelefrm : Form
    {
        public İlacListelefrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * from ilac ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ilacListele.DataSource = ds.Tables[0];

        }
    }
}
