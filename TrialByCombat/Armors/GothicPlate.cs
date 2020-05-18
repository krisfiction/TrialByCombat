namespace TrialByCombat.Armors
{
    internal class GothicPlate : Armor
    {
        public GothicPlate(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Gothic Plate";
            Description = "gothic plate armor";
            Slot = slot;
            Gold = 8000;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 50;
            ArmorHigh = 60;
            ArmorClass = Armor.ArmorRoll(ArmorLow, ArmorHigh);
        }
    }
}