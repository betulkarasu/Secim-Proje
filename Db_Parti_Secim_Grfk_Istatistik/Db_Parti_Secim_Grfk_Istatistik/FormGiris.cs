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

namespace Db_Parti_Secim_Grfk_Istatistik
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=BETšSPC\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void btnOY_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutOyEkle = new SqlCommand("insert into tbl_ilce (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komutOyEkle.Parameters.AddWithValue("@p1", txtilcead.Text);
            komutOyEkle.Parameters.AddWithValue("@p2", txtA.Text);
            komutOyEkle.Parameters.AddWithValue("@p3", txtB.Text);
            komutOyEkle.Parameters.AddWithValue("@p4", txtC.Text);
            komutOyEkle.Parameters.AddWithValue("@p5", txtD.Text);
            komutOyEkle.Parameters.AddWithValue("@p6", txtE.Text);

            komutOyEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişiniz Başarılı.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FormGrafikler Fgrfk = new FormGrafikler();
            Fgrfk.Show();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
