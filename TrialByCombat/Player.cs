using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialByCombat.Potions;
using TrialByCombat.Scrolls;

namespace TrialByCombat
{
    public class Player : Characters
    {
        public int MANA { get; set; }


        public int ACbase { get; set; }
        public int AC { get; set; }




        public int STR { get; set; }
        public int INT { get; set; }


        public string HeadName { get; set; }
        public int HeadCost { get; set; }
        public int HeadWeight { get; set; }
        public int HeadArmorBonus { get; set; }

        public string ShouldersName { get; set; }
        public int ShouldersArmorBonus { get; set; }


        public string ArmsName { get; set; }
        public int ArmsArmorBonus { get; set; }

        public string HandsName { get; set; }
        public int HandsArmorBonus { get; set; }


        public string ChestName { get; set; }
        public int ChestCost { get; set; }
        public int ChestWeight { get; set; }
        public int ChestArmorBonus { get; set; }


        public string WaistName { get; set; }
        public int WaistArmorBonus { get; set; }


        public string LegsName { get; set; }
        public int LegsArmorBonus { get; set; }

        public string FeetName { get; set; }
        public int FeetArmorBonus { get; set; }




        public int Shield { get; set; } = 0;
      
    }
}
