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
        public string year { get; set; }
        public string model { get; set; }
        public string sale_price { get; set; }


        public CarData()
        {
            vin = string.Empty;
            make = string.Empty;
            color = string.Empty;
            year = string.Empty;
            model = string.Empty;
            sale_price = string.Empty;
        }
        
        public override string ToString()
        {
            return $"{year} {make} - {model}";
              
        }
        
    }
}
