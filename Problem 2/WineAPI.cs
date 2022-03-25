using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    public class WineAPI
    {
        public double id             {get;set;}
        public double points         {get;set;}
        public double? price          {get;set;}
        public string country        {get;set;}
        public string description    {get;set;}
        public string designation    {get;set;}
        public string province       {get;set;}
        public string region1        {get;set;}
        public string region2        {get;set;}
        public string taster_name    {get;set;}
        public string taster_twitter {get;set;}
        public string title          {get;set;}
        public string variety        {get;set;}
        public string winery         {get; set;}

        public WineAPI()
        {
            id = 0;
            points = 0;
            price = 0;
            country       = string.Empty;
            description   = string.Empty;
            designation   = string.Empty;
            province      = string.Empty;
            region1       = string.Empty;
            region2       = string.Empty;
            taster_name   = string.Empty;
            taster_twitter= string.Empty;
            title         = string.Empty;
            variety       = string.Empty;
            winery        = string.Empty;
        }

        public override string ToString()
        {
            return $"{price} { title}";
        }

    }
}
