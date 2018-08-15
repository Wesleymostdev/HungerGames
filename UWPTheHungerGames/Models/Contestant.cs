using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPTheHungerGames.Models
{
    public class Contestant
    {
        /// <summary>
        /// Get and set Id for contestant
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get and set Name for contestant
        /// </summary>
        public string Name { get; set; }

        public Contestant(int id, string name, Gender gender, District district )
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.District = district;
            
        }

        public Gender Gender { get; set; }
        public District District { get; set; }
    }
}

