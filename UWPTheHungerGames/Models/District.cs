using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPTheHungerGames.Models
{
    public class District
    {
        public int Id { get; set; }

        private string districtName;

        public string DistrictName
        {
            get
            {
                return districtName;
            }
            set
            {
                districtName = value;
            }
        }

        public override string ToString()
        {
            return districtName.ToString();
        }
    }
}
