using System;
using Creation;

namespace PlayerCharacter
{
    public class Character // add many refresh commands for stats, and update commands
    {
        private string _characterID;

        public string CharacterID
        {
            get
            {
                return _characterID;
            }
            set
            {
                _characterID = value;
            }
        }
        private string _characterPass;
        public string CharacterPass
        {
            get
            {
                return _characterPass;
            }
            set
            {
                _characterPass = value;
            }
        }
        private int _characterLevel;
        public int CharacterLevel
        {
            get
            {
                return _characterLevel;
            }
            set
            {
                _characterLevel = value;
            }
        }
        private int _characterEXP;  // add EXP method that has input for int of exp, changes the private value of exp and then does a refresh check on the exp to check for level up
        public int CharacterEXP
        {
            get
            {
                return _characterEXP;
            }
            set
            {
                _characterEXP = value;
            }
        }
        private string _characterLocation;
        public string CharacterLocation
        {
            get
            {
                return _characterLocation;
            }
            set
            {
                _characterLocation = value;
            }
        }
        private int _characterSTR;
        public int CharacterSTR
        {
            get
            {
                return _characterSTR;
            }
            set
            {
                _characterSTR = value;
            }
        }
        private int _characterDEX;
        public int CharacterDEX
        {
            get
            {
                return _characterDEX;
            }
            set
            {
                _characterDEX = value;
            }
        }
        private int _characterEND;
        public int CharacterEND
        {
            get
            {
                return _characterEND;
            }
            set
            {
                _characterEND = value;
            }
        }
        private int _characterWIL;
        public int CharacterWIL
        {
            get
            {
                return _characterWIL;
            }
            set
            {
                _characterWIL = value;
            }
        }
        private int _characterINT;
        public int CharacterINT
        {
            get
            {
                return _characterINT;
            }
            set
            {
                _characterINT = value;
            }
        }
        private int _characterWIS;
        public int CharacterWIS
        {
            get
            {
                return _characterWIS;
            }
            set
            {
                _characterWIS = value;
            }
        }
        private int _characterefSTR;
        public int CharacterefSTR
        {
            get
            {
                return _characterefSTR;
            }
            set
            {
                _characterefSTR = value;
            }
        }
        private int _characterefDEX;
        public int CharacterefDEX
        {
            get
            {
                return _characterefDEX;
            }
            set
            {
                _characterefDEX = value;
            }
        }
        private int _characterefEND;
        public int CharacterefEND
        {
            get
            {
                return _characterefEND;
            }
            set
            {
                _characterefEND = value;
            }
        }
        private int _characterefWIL;
        public int CharacterefWIL
        {
            get
            {
                return _characterefWIL;
            }
            set
            {
                _characterefWIL = value;
            }
        }
        private int _characterefINT;
        public int CharacterefINT
        {
            get
            {
                return _characterefINT;
            }
            set
            {
                _characterefINT = value;
            }
        }
        private int _characterefWIS;
        public int CharacterefWIS
        {
            get
            {
                return _characterefWIS;
            }
            set
            {
                _characterefWIS = value;
            }
        }
        private int _characterMAXHP;
        public int CharacterMAXHP
        {
            get
            {
                return _characterMAXHP;
            }
            set
            {
                _characterMAXHP = value;
            }
        }
        private int _characterMAXPP;
        public int CharacterMAXPP
        {
            get
            {
                return _characterMAXPP;
            }
            set
            {
                _characterMAXPP = value;
            }
        }
        private int _characterMAXSP;
        public int CharacterMAXSP
        {
            get
            {
                return _characterMAXSP;
            }
            set
            {
                _characterMAXSP = value;
            }
        }
        private int _characterHP;
        public int CharacterHP
        {
            get
            {
                return _characterHP;
            }
            set
            {
                _characterHP = value;
            }
        }
        private int _characterPP;
        public int CharacterPP
        {
            get
            {
                return _characterPP;
            }
            set
            {
                _characterPP = value;
            }
        }
        private int _characterSP;
        public int CharacterSP
        {
            get
            {
                return _characterSP;
            }
            set
            {
                _characterSP = value;
            }
        }

        public bool Login(string EnteredPass)
        {
            if (EnteredPass == CharacterPass)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Accepted.");
                Console.ResetColor();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect Password.");
                Console.ResetColor();
                return false;
            }
        }

        public void Creation()
        {
            bool Decision = CharacterCreation.CharacterWelcome();
            if (Decision == false)
            {
                Console.WriteLine("");
                return;
            }
            CharacterID = CharacterCreation.CharacterName();
            Console.WriteLine("\r\nYour name is " + CharacterID + ".\r\n");
            CharacterPass = CharacterCreation.CharacterPass();
            Console.WriteLine("\r\nYour password is " + CharacterPass + ", please remember it.\r\n");
            CharacterLevel = 1;
            CharacterEXP = 0;
            CharacterLocation = "town";
            CharacterSTR = 2;
            CharacterDEX = 2;
            CharacterEND = 2;
            CharacterWIL = 2;
            CharacterINT = 2;
            CharacterWIS = 2;
            FullRefresh();
            Console.WriteLine("\r\nYour character was successfully created.\r\n");
            return;
        }
        public void LevelCheck()
        {
            // add a system to check exp and grant levels
        }
        public void LevelUp()
        {
            // add a level up system
        }
        public void PointRefresh()
        {
            CharacterPP = CharacterMAXPP;
            CharacterSP = CharacterMAXSP;
        }
        public void FullRefresh()
        {
            CharacterMAXHP = CharacterEND + CharacterWIL;
            CharacterHP = CharacterMAXHP;
            if (CharacterDEX == 0)
            {
                CharacterMAXPP = 0;
            }
            else if (CharacterDEX == 1)
            {
                CharacterMAXPP = 0;
            }
            else if (CharacterDEX % 2 == 0)
            {
                CharacterMAXPP = (CharacterDEX / 2) + 1;
            }
            else
            {
                int EffectiveDEX = CharacterDEX - 1;
                CharacterMAXPP = (EffectiveDEX / 2) + 1;
            }
            CharacterPP = CharacterMAXPP;
            if (CharacterWIS == 0)
            {
                CharacterMAXSP = 0;
            }
            else if (CharacterWIS == 1)
            {
                CharacterMAXSP = 0;
            }
            else if (CharacterWIS % 2 == 0)
            {
                CharacterMAXSP = (CharacterWIS / 2) + 1;
            }
            else
            {
                int EffectiveWIS = CharacterWIS - 1;
                CharacterMAXSP = (EffectiveWIS / 2) + 1;
            }
            CharacterSP = CharacterMAXSP;
            CharacterefSTR = CharacterSTR;
            CharacterefDEX = CharacterDEX;
            CharacterefEND = CharacterEND;
            CharacterefWIL = CharacterWIL;
            CharacterefINT = CharacterINT;
            CharacterefWIS = CharacterWIS;
        }
        public void CharacterStats()
        {
            Console.WriteLine("\r\nName: {0}", CharacterID);
            Console.WriteLine("Level: {0}", CharacterLevel, "\r\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("STR (Effective): {0} ({1})", CharacterSTR, CharacterefSTR);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DEX (Effective): {0} ({1})", CharacterDEX, CharacterefDEX);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("END (Effective): {0} ({1})", CharacterEND, CharacterefEND);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("WIL (Effective): {0} ({1})", CharacterWIL, CharacterefWIL);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("INT (Effective): {0} ({1})", CharacterINT, CharacterefINT);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WIS (Effective): {0} ({1})", CharacterWIS, CharacterefWIS);
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("EXP: {0}", CharacterEXP);
            Console.WriteLine("Skills: ", "\r\n");

        }
    }
    
}