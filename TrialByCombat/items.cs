using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Items // every item in game
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slot { get; set; }
        public int Gold { get; set; }
        //public int Weight { get; set; }
    }
}