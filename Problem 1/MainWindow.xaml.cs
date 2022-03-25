using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Problem_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CarData> Cars = new List<CarData>();
        public MainWindow()
        {
            InitializeComponent();
            CarData cars = new CarData();

            string[] filelines = File.ReadAllLines("car_sales.csv");
            comboColor.Items.Add("All");
            comboColor.SelectedIndex = 0;

            for (int i = 0; i < filelines.Length; i++)
            {
                string[] pieces = filelines[i].Split(',');

                cars.vin = Convert.ToChar(pieces[0]);
                cars.make = pieces[1];
                cars.color = pieces[2];
                cars.year = Convert.ToInt32(pieces[3]);
                cars.model = pieces[4];
                cars.sale_price = Convert.ToDouble(pieces[5]);

                foreach (CarData data in Cars)
                {
                    lstCars.Items.Add(cars);
                }

                if (comboColor.Items.Contains(cars.color) == false)
                {
                    comboColor.Items.Add(cars.color);
                }
            }
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            string color = comboColor.SelectedItem.ToString();
            string year;
            lstCars.Items.Clear();
            year = txtYear.Text;


            foreach (var car in Cars)
            {
                if (car.color == color //|| car.year <= year
                                       )
                {
                   
                    lstCars.Items.Add(car);
                    
                }
            }
            lblResults.Content = $"Record Count: {lstCars.Items.Count.ToString("N0")}";
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstCars.Items);
            File.WriteAllText("cars.json", json);

            MessageBox.Show("Successfully exported data to cars.json");
        }
    }
}
