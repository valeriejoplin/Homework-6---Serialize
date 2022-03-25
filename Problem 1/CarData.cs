using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    public class CarData
    {
        public string vin { get; set; }
        public string make { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public string model { get; set; }
        public double sale_price { get; set; }


        public CarData()
        {
            vin = string.Empty;
            make = string.Empty;
            color = string.Empty;
            year = 0;
            model = string.Empty;
            sale_price = 0 ;
        }
        
        public override string ToString()
        {
            return $"{year} {make} - {model}";
              
        }
        
    }
}
