namespace TrialByCombat.Armors
{
    internal class FieldPlate : Armor
    {
        public FieldPlate(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Field Plate";
            Description = "field plate armor";
            Slot = slot;
            Gold = 5800;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 40;
            ArmorHigh = 45;
            ArmorClass = Roll(ArmorLow, ArmorHigh);
        }
    }
}