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
namespace Personel_Kayit
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-IQ1GDIUE\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Yonetici(KullaniciAd,Sifre) values (@k1,@k2)", baglanti);
            komut.Parameters.AddWithValue("@k1", textBox1.Text);
            komut.Parameters.AddWithValue("@k2", textBox2.Text);



            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıdınız başarıyla gerçekleşmiştir.");
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Hide();
        }
    }
}
