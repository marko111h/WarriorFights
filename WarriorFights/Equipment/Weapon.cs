using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        //fields

        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;

        // primitive data types
        private int damage;
        private string chooseWeapon;

        //property for Weapon
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public string ChooseWeapon
        {
            get
            {
                if (chooseWeapon == "Axe")
                {
                    chooseWeapon = "3";
                }
                else if (chooseWeapon == "Sword")
                {
                    chooseWeapon = "5";
                }
                else if (chooseWeapon == "Polearm");
                {
                     chooseWeapon = "9";
                }
                return chooseWeapon;
            }
        }

        //constructor

        public Weapon (Faction faction)
        {
           int wp = int.Parse(ChooseWeapon);

            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE + wp;
                    break;
               case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE + wp;
                    break;
               default:
                    break;
            }

        }

    }
}
