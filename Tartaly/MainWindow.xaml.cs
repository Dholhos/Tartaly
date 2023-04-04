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
using Osztályok;

namespace Tartaly
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

        private void rdoTeglatest_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = true;
            txtBel.IsEnabled = true;
            txtCel.IsEnabled = true;
            txtAel.Text = "";
            txtBel.Text = "";
            txtCel.Text = "";
        }

        private void rdoKocka_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = false;
            txtBel.IsEnabled = false;
            txtCel.IsEnabled = false;
            txtAel.Text = "10";
            txtBel.Text = "10";
            txtCel.Text = "10";
        }
        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {
            Tartaly ujTest;

            ujTest = new Tartaly(txtNev.Text, Convert.ToInt32(txtAel.Text), Convert.ToInt32(txtBel.Text), Convert.ToInt32(txtCel.Text));
            lbTartalyok.Items.Add(ujTest.Info());
            tartalyok.Add(ujTest);
        }
        private void btntolt_Click(object sender, RoutedEventArgs e)
        {
            if (lbTartalyok.SelectedIndex >= 0)
            {
                tartalyok[lbTartalyok.SelectedIndex].Tolt(Convert.ToDouble(txtMennyitTolt.Text));
                lbTartalyok.Items[lbTartalyok.SelectedIndex] = tartalyok[lbTartalyok.SelectedIndex].Info();

            }
        }

        private void btnDuplaz_Click(object sender, RoutedEventArgs e)
        {
            if (lbTartalyok.SelectedIndex >= 0)
            {
                tartalyok[lbTartalyok.SelectedIndex].DuplazMeretet();
                lbTartalyok.Items[lbTartalyok.SelectedIndex] = tartalyok[lbTartalyok.SelectedIndex].Info();

            }
        }
    }
