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
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=BETšSPC\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            // İlçe Adlarını Combobox'a çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD From tbl_ilce", baglanti);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboIlceler.Items.Add(dr[0]).ToString();
            }
            baglanti.Close();

            // Grafiğe Toplam Sonuçları Getirme

            baglanti.Open();
            SqlCommand Komut2 = new SqlCommand("Select sum(APARTI), sum(BPARTI), SUM (CPARTI), SUM(DPARTI), SUM(EPARTI) FROM Tbl_ilce", baglanti);
            SqlDataReader dr2 = Komut2.ExecuteReader();
            while (dr2.Read()) {

                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);

                               }
            baglanti.Close();

            // Seçilen Partinin Oy Oranını Görme



        }

        private void comboIlceler_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from tbl_ilce where ILCEAD=@P1", baglanti);

            komut3.Parameters.AddWithValue("@p1", comboIlceler.Text);
            SqlDataReader DR1 = komut3.ExecuteReader();
            while (DR1.Read())
            {
                progressBar1.Value = int.Parse(DR1[2].ToString());
                progressBar2.Value = int.Parse(DR1[3].ToString());
                progressBar3.Value = int.Parse(DR1[4].ToString());
                progressBar4.Value = int.Parse(DR1[5].ToString());
                progressBar5.Value = int.Parse(DR1[6].ToString());

                lblA.Text = DR1[2].ToString();
                lblB.Text = DR1[3].ToString();
                lblC.Text = DR1[4].ToString();
                lblD.Text = DR1[5].ToString();
                lblE.Text = DR1[6].ToString();

            }
            baglanti.Close();

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
