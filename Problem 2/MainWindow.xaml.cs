using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace Problem_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<WineAPI> wines;
        public MainWindow()
        {
            InitializeComponent();
            string url = "http://pcbstuou.w27.wh-2.com/webservices/3033/api/Wine/Reviews";
            comboCountry.Items.Add("All");
            comboCountry.SelectedIndex = 0;
          
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                wines = JsonConvert.DeserializeObject<List<WineAPI>>(json);

            }
            foreach (var wine in wines)
            {
                lstWine.Items.Add(wine);

                if (comboCountry.Items.Contains(wine.country)==false)
                {
                    comboCountry.Items.Add(wine.country);
                }
            }
            
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string country = comboCountry.SelectedItem.ToString();
            double? price;
            lstWine.Items.Clear();
            if (string.IsNullOrWhiteSpace(txtPrice.Text) == true)
            {
                price = null;
            }
            else
            {
                price = Convert.ToDouble(txtPrice.Text);
            }

            foreach (var wine in wines)
            {
                if (wine.country == country)
                {
                    if (price == null ||wine.price <= price)
                    {
                        lstWine.Items.Add(wine);
                    }
                    
                }
            }
            lblRecord.Content = $"Record Count: {lstWine.Items.Count.ToString("N0")}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstWine.Items);
            File.WriteAllText("wines.json", json);

            MessageBox.Show("Successfully exported data to wines.json");
        }

        private void lstWine_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WineDetails details = new WineDetails();
            details.PopulateData((WineAPI)lstWine.SelectedItem);
            details.ShowDialog();
        }
    }
}
