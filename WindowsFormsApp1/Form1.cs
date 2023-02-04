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
    public partial class Form1 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=mbys;User Id=postgres;Password=1234");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void poliklinikDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliklinikDefteri poliklinikDefteri = new PoliklinikDefteri();
            poliklinikDefteri.Show();

        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaEkle hastaEkle = new HastaEkle();
            hastaEkle.Show();
        }

        private void hastaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hasta_Listele hasta_Listele = new Hasta_Listele();
            hasta_Listele.Show();
        }

        private void hastaTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaTakipfrm hastatakip = new HastaTakipfrm();
            hastatakip.Show();
        }

        private void ilaçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İlacEklefrm ilacekle = new İlacEklefrm();
            ilacekle.Show();
        }

        private void reçeteEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Show();
        }

        private void muayeneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muayenefrm muayenefrm=new Muayenefrm();
            muayenefrm.Show();
        }

        private void ilaçTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İlacTakipfrm ilactakipfrm = new İlacTakipfrm();
            ilactakipfrm.Show();

        }

        private void ilaçListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İlacListelefrm ilacListe = new İlacListelefrm();
            ilacListe.Show();
        }
    }
}
