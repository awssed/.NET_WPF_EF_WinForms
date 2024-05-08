using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_WinFromsControlElements_
{
    public class Manufacturer
    {
        public string name;
        public int year;
        public string country;
        Flight.typeOfPlane[] types;
        public Manufacturer(string name, int year, string country, Flight.typeOfPlane[] types)
        {
            this.name = name;
            this.year = year;
            this.country = country;
            this.types = types;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"Year: {year}");
            sb.AppendLine($"Country: {country}");
            return sb.ToString();
        }
    }
    
}
