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

namespace Problem_2
{
    /// <summary>
    /// Interaction logic for WineDetails.xaml
    /// </summary>
    public partial class WineDetails : Window
    {
        public WineDetails()
        {
            InitializeComponent();
        }

        public void PopulateData(WineAPI wine)
        {
            
            txtDesc.Text = wine.description;
            txtPoints.Text = wine.points.ToString();
            txtVarietal.Text = wine.variety;
            txtWinery.Text = wine.winery;
            lblTitle.Content = wine.title;
        }
    }
}
