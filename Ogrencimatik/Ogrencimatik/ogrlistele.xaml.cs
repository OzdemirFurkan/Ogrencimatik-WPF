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
using System.Data;
using System.Data.SqlClient;
namespace Ogrencimatik
{
    /// <summary>
    /// Interaction logic for ogrlistele.xaml
    /// </summary>
    public partial class ogrlistele : Window
    {
        public ogrlistele()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source =SQL6001.myASP.NET;Initial Catalog=DB_A1FDEC_ogrencimatik;User Id=DB_A1FDEC_ogrencimatik_admin;Password=1252D7951753;");

        DataTable tablo = new DataTable();

        public void listele()
        {
            SqlCommand sorgu = new SqlCommand("select * From Ogrenciler", baglan);
            SqlDataAdapter adap = new SqlDataAdapter(sorgu);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGrid.DataContext = ds.Tables[0];
        }
        private void txtogrlsara_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ogrlsls_Click(object sender, RoutedEventArgs e)
        {
          //  dataGrid.Visible = true;
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand sorgu = new SqlCommand("select * from Ogrenciler", baglan);
                SqlDataAdapter dr = new SqlDataAdapter(sorgu);
                DataSet ds = new DataSet();
                dr.Fill(ds, "bilgi");
                dataGrid.DataContext = ds.Tables[0];
                baglan.Close();

            }


            catch (Exception hata)
            {

                MessageBox.Show("hata olştu " + hata);
            }
        }

        private void btnogrlssil_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Kaydı silmek istiyormusunuz?", "Öğrenci Sil!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                baglan.Open();
                SqlCommand sorgu = new SqlCommand("delete from Ogrenciler where ogrNo='" + dataGrid.SelectedCells[0] + "'", baglan);

                //SqlCommand sorgu = new SqlCommand("delete from Ogrenciler where ogrNo='" + txtogrNosil.Text + "'", baglan);
                //  txtoglssil.Text = "";

                sorgu.ExecuteNonQuery(); // sql kaydı silmek için
                baglan.Close();
                MessageBox.Show("Kayıt Silindi");
                listele();

            }
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
