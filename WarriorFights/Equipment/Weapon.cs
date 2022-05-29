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
        private int chooseWeapon;

        //property for Weapon
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public int ChooseWeapon
        {
            get
            {

                return chooseWeapon;
                
              
            }
        }

        //constructor

        public Weapon (Faction faction, int chooseWeapon)
        {
           

            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE + chooseWeapon;
                    break;
               case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE + chooseWeapon;
                    break;
               default:
                    break;
            }

        }

    }
}
