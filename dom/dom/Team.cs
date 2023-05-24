using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
   public class Team
    {
        public List<Football_palyer> football_Palyers { get; set; } = new List<Football_palyer>();
        public double averageAgeOfThePlayers { get; set; }
    }
}
