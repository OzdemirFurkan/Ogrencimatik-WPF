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

namespace Ogrencimatik
{
    /// <summary>
    /// Interaction logic for islemler.xaml
    /// </summary>
    public partial class islemler : Window
    {
        public islemler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void btnislemogrekle_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window frmogrencikayit = new ogrencikayit();
            frmogrencikayit.Show();

        }

        private void btnislemlerdvmszlk_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window frmdevamsizlik = new devamsizlik();
            frmdevamsizlik.Show();

        }

        private void btnislemlerdnm_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window frmdenemebilgiler = new deneme();
            frmdenemebilgiler.Show();
        }

        private void btnislemlerucrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window emailForm = new email();
            emailForm.Show();

        }

        private void btnislemlerogrlst_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window frmogrlistele = new ogrlistele();
            frmogrlistele.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window frmmfrdt = new mufredat();
            frmmfrdt.Show();
        }

    }
}
