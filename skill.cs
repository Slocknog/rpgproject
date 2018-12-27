using System;
using System.Collections.Generic;

namespace Skills
{
    public class SpellbookInitialize
    {
        public void ListBook()
        {
            Dictionary<int, string> SpellList = new Dictionary<int, string>();
            SpellList[0] = "null";
            SpellList[1] = "powerattack";
            SpellList[2] = "flashfreeze";
            SpellList[3] = "necroticmoss";
        }





    }
    public class Spells
    {
        public static int PowerAttack(int STR)
        {
            double Damage = STR * 1.5;
            return Convert.ToInt32(Damage);
        }

    }
}
