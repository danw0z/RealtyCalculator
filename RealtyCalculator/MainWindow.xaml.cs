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

namespace RealtyCalculator
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double brokerPercentage = .5;
            if (checkBox.IsChecked == true)
            {
                brokerPercentage = .64;
            }

            double mMove = 1;
            if (checkBox1.IsChecked == true)
            {
                mMove = .7;
            }

            try
            {
                float salesPrice = (float)Convert.ToDouble(textBox.Text);
                bool valid = float.TryParse(textBox.Text.ToString(), out salesPrice);

                float commissionPercentage = (float)Convert.ToDouble(textBox1.Text);
                bool valid2 = float.TryParse(textBox1.Text.ToString(), out commissionPercentage);
     
                double commission = (salesPrice * (commissionPercentage / 100)) * brokerPercentage * mMove;
                textBox2.Text = commission.ToString("$#.##");
            }
            catch
            {
                MessageBox.Show("Check your numbers!");
            }
            

        }

        private void sellerButton_Click(object sender, RoutedEventArgs e)
        {
            double brokerPercentage = .5;

            double mMove = 1;
            if (sellerCheckBox1.IsChecked == true)
            {
                mMove = .7;
            }

            try
            {
                float salesPrice = (float)Convert.ToDouble(sellerTextBox.Text);
                bool valid = float.TryParse(sellerTextBox.Text.ToString(), out salesPrice);

                float commissionPercentage = (float)Convert.ToDouble(sellerTextBox1.Text);
                bool valid2 = float.TryParse(sellerTextBox1.Text.ToString(), out commissionPercentage);

                double commission = (salesPrice * (commissionPercentage / 100)) * brokerPercentage * mMove;
                sellerTextBox2.Text = commission.ToString("$#.##");
            }
            catch
            {
                MessageBox.Show("Check your numbers!");
            }
        }

        private void hudButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                float netToHud = (float)Convert.ToDouble(hudTextBox.Text);
                bool valid = float.TryParse(hudTextBox.Text.ToString(), out netToHud);

                float commissionPercentage = (float)Convert.ToDouble(hudTextBox1.Text);
                bool valid2 = float.TryParse(hudTextBox1.Text.ToString(), out commissionPercentage);

                float closingCosts = (float)Convert.ToDouble(hudTextBox3.Text);
                bool valid3 = float.TryParse(hudTextBox3.Text.ToString(), out closingCosts);

                double newBid = (netToHud / ((100-commissionPercentage) / 100)) + closingCosts;
                hudTextBox2.Text = newBid.ToString("$#.##");
            }
            catch
            {
                MessageBox.Show("Check your numbers!");
            }
        }

    }
}
