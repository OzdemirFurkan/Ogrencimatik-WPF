using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Ogrencimatik
{
    /// <summary>
    /// Interaction logic for ogrencikayit.xaml
    /// </summary>
    public partial class ogrencikayit : Window
    {
        public ogrencikayit()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source =SQL6001.myASP.NET;Initial Catalog=DB_A1FDEC_ogrencimatik;User Id=DB_A1FDEC_ogrencimatik_admin;Password=1252D7951753;");

        SqlDataAdapter adaptor = new SqlDataAdapter();
        DataSet ds = new DataSet();


        public void temizle()
        {
            txtogrkytad.Text = "";
            txtogrkytsoyad.Text = "";
            txtogrkytilce.Text = "";
            mtxtogrkyttel.Text = "";
            txtogrkytegtm.Text = "";
            rtxtogrkytadrs.Text = "";
            txtogrkytokl.Text = "";
            txtogrkytdonem.Text = "";
            txtogrkytvad.Text = "";
            txtogrkytvsyd.Text = "";
            txtogrkytvtel.Text = "";
            txtogrkytvmail.Text = "";
         //   rbtnogrkyterk.Checked = false;
          //  rbtnogrkytkdn.Checked = false;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window frmislemler = new islemler();
            frmislemler.Show();
        }

        private void btnogrkytekle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                ds.Clear();

                //sorgudaki cinsiyeti sildim
                SqlCommand komut = new SqlCommand("insert into Ogrenciler(Ad,Soyad,Adres,Tel,EgitimDurumu,Ilce,Okul,Donem,VeliAd,VeliSoyad,VeliTel,VeliMail) values ('" + txtogrkytad.Text + "','" + txtogrkytsoyad.Text + "','" + rtxtogrkytadrs.Text + "','" + mtxtogrkyttel.Text + "','" + txtogrkytegtm.Text + "','" + txtogrkytilce.Text + /*"','" + rbtnogrkytkdn.Checked + */"','" + txtogrkytokl.Text + "','" + txtogrkytdonem.Text + "','" + txtogrkytvad.Text + "','" + txtogrkytvsyd.Text + "','" + txtogrkytvtel.Text + "','" + txtogrkytvmail.Text + "')", baglan);
                komut.ExecuteNonQuery();
                
                MessageBox.Show("Kayıt Eklendi");
                temizle();
                baglan.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex);
            }
        }

        private void rtxtogrkytadrs_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnogrkytiptal_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("işleminiz iptal edildi");
            temizle();
        }

        private void rbtnogrkyterk_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
