using WarriorWars.Equipment;
using WarriorWars.Enum;

namespace WarriorWars
{
    class Warrior
    {
        //fields
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        private readonly Faction FACTION;

        // primitive data types
        private double heatlh;
      private  string name;
        private int chooseWeapon;
        private string nameOfWeapon;
        private bool isAlive;

        //property for cheaking warrior isAlive
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        //constructor
        public Warrior( string name, Faction faction , int chooseWeapon , string nameOfWeapon)
        {
            this.name = name;
            this.chooseWeapon = chooseWeapon;
            this.nameOfWeapon = nameOfWeapon;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction, chooseWeapon);
                    armor = new Armor(faction);
                    heatlh = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction, chooseWeapon);
                    armor = new Armor(faction);
                    heatlh = BAD_GUY_STARTING_HEALTH;
                    break;
               default:
                    break;
            }

        }

        public void Attack(Warrior enemy)
        {
            int numb = 0;
            int damage = 0;
             Random rng = new Random();
            ///
            /// Critical Damage
          if ((rng.Next(0, 10) >= 7))
            {
                damage = damage + rng.Next(7, 10);
            }

             damage = damage + (weapon.Damage / enemy.armor.ArmorPoints);

            enemy.heatlh = enemy.heatlh - damage;

            AttackResult(enemy, damage);
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.heatlh <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($" {name} is victorious!", ConsoleColor.Green);

            }
            else
            {
                if(damage > 6)
                {
                    Console.WriteLine($"{name} attacked with {nameOfWeapon} {enemy.name} with critical {damage} damage  was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.heatlh}");
                } else
                {

                
                Console.WriteLine($"{name} attacked with {nameOfWeapon} {enemy.name}. {damage} damage  was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.heatlh}");
                }
            }
        }

    }
}
