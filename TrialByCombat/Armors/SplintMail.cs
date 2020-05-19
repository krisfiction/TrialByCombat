namespace TrialByCombat.Armors
{
    internal class SplintMail : Armor
    {
        public SplintMail(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Splint mail";
            Description = "splint mail armor";
            Slot = slot;
            Gold = 3250;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 30;
            ArmorHigh = 35;
            ArmorClass = Roll(ArmorLow, ArmorHigh);
        }
    }
}