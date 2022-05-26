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
        private string chooseWeapon;
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
        public Warrior( string name, Faction faction , string chooseWeapon)
        {
            this.name = name;
            this.chooseWeapon = chooseWeapon;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    heatlh = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    heatlh = BAD_GUY_STARTING_HEALTH;
                    break;
               default:
                    break;
            }

        }

        public void Attack(Warrior enemy)
        {
            int damage = 0;
             Random rng = new Random();
            ///
            /// Critical Damage
          if ( rng.Next(0, 10) >= 7)
            {
                damage = damage + rng.Next(0, 10);
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
                if(damage > 5)
                {
                    Console.WriteLine($"{name} attacked with {chooseWeapon} {enemy.name} with critical {damage} damage  was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.heatlh}");
                }
                Console.WriteLine($"{name} attacked with {chooseWeapon} {enemy.name}. {damage} damage  was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.heatlh}");
            }
        }

    }
}
