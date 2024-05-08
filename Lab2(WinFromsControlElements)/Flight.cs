using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab2_WinFromsControlElements_
{
    [AircraftIDAtribute("^[0-9]+$")]
    public class Flight
    {
        [Required(AllowEmptyStrings = false)]
        public string id;
        public Manufacturer model;
        public typeOfPlane type = typeOfPlane.civilian;
        public List<CrewMember> members = new List<CrewMember>();
        [Range(1,500)]
        public int numberOfSeats = 0;
        public int yearOfReales = 1980;
        public DateTime lastTecServ = new DateTime();
        public int weight = 0;

        public enum typeOfPlane
        {
            civilian,
            freight,
            military
        }   
        public enum modelOfPlane
        {
            Boeing,
            Airbus,
            Embraer,
            CRJ,
            none
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Flight ID: {id}");
            sb.AppendLine($"Manufacturer:{model.ToString()}");
            sb.AppendLine($"Type: {type}");
            sb.AppendLine($"Number of Seats: {numberOfSeats}");
            sb.AppendLine($"Year of Release: {yearOfReales}");
            sb.AppendLine($"Last Technical Service: {lastTecServ}");
            sb.AppendLine($"Weight: {weight}");
            sb.AppendLine("Crew Members:");
            foreach (CrewMember member in members)
            {
                sb.AppendLine(member.ToString());
            }
            return sb.ToString();
        }
    }
    public class AircraftIDAtribute:Attribute
    {
        public Regex pattern { get; }
        public AircraftIDAtribute() { }
        public AircraftIDAtribute(string pat)
        {
            pattern = new Regex(pat);
        }
    }
}
