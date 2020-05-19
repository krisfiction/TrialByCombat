namespace TrialByCombat.Armors
{
    internal class _BlankArmor : Armor
    {
        public _BlankArmor(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "";
            Description = "";
            Slot = slot;
            Gold = 5;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 1;
            ArmorHigh = 5;
            ArmorClass = Roll(ArmorLow, ArmorHigh);
        }
    }
}

//TODO notes - remove me
/*
    to create new Rags armor - put this in loot generator

    Rags rags = new Rags("Chest", "pre", "health", 5, "suf", "magic", 10);
    rags.ArmorAddToInventory();

    random variables that need passed to Rags()
    Slot
    Prefix Name
    Prefix Stat
    Prefix Value
    Suffix Name
    Suffix Stat
    Suffix Value
*/
