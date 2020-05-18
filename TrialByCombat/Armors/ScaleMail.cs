namespace TrialByCombat.Armors
{
    internal class ScaleMail : Armor
    {
        public ScaleMail(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Scale Mail";
            Description = "scale mail armor";
            Slot = slot;
            Gold = 2300;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 23;
            ArmorHigh = 28;
            ArmorClass = Armor.ArmorRoll(ArmorLow, ArmorHigh);
        }
    }
}