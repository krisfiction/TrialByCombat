using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    public class Equipment : Items
    {
        public string PrefixName { get; set; }
        public string PrefixStat { get; set; }
        public int PrefixValue { get; set; }
        public string SuffixName { get; set; }
        public string SuffixStat { get; set; }
        public int SuffixValue { get; set; }
    }
}
