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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Ogrencimatik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source =SQL6001.myASP.NET;Initial Catalog=DB_A1FDEC_ogrencimatik;User Id=DB_A1FDEC_ogrencimatik_admin;Password=1252D7951753;");

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlParameter kad = new SqlParameter("@kadi", txtAd.Text);
                SqlParameter sifre = new SqlParameter("@sifre", txtSifre.Password);

                string sorgu = "select * from uye where KullaniciAd=@kadi and Sifre=@sifre";
                SqlCommand komut = new SqlCommand(sorgu, baglan);

                //SqlCommand sorgu = new SqlCommand("select * from Kullanici where KullaniciAdi=@kadi and Sifre=@sifre", baglan);
                komut.Parameters.Add(kad);
                komut.Parameters.Add(sifre);

                SqlDataAdapter adap = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adap.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Hoşgeldiniz " + txtAd.Text);
                    txtAd.Text = "";
                    txtSifre.Password = "";

                    this.Hide();
                    Window frmislem = new islemler();
                    frmislem.Show();

                }

                else
                {
                    MessageBox.Show("Kullanıcı adını veya şifreyi yanlış girdiniz");
                    txtAd.Text = "";
                    txtSifre.Password = "";
                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex);
            }

            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Islem Iptal Edildi...");
            txtAd.Text = "";
            txtSifre.Password = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            txtSifre.PasswordChar = '\0';

        }
    }
}

