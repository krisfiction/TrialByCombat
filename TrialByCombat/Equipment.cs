using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Equipment : Items
    {
        public string PrefixName { get; set; } // prefix Name - Awesome
        public string PrefixStat { get; set; } // prefix Stat - Health
        public int PrefixValue { get; set; } // prefix Value - 25
        public string SuffixName { get; set; } // suffix Name - of the Wolf
        public string SuffixStat { get; set; } // suffix Stat - Mana
        public int SuffixValue { get; set; } // suffix Value 15
    }
}
