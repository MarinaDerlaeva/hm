using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
   public class Game : Team
    {
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Referee> refAssistant { get; set; } = new List<Referee>();
        public List<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
