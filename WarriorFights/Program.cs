using WarriorWars.Enum;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();
       
        static void Main()
        {

            Console.WriteLine("Choose Your Fighter ");
            string[] chooseYourFighter = { "Recko", "Bane", "Lalat", "Dragan" };
             string[] chooseWeapon = { "Axe", "Sword", "Polearm" };

            //// show figters
            Console.WriteLine(string.Join(" ", chooseYourFighter));
            string fighter1 =  Console.ReadLine(); ///////
            /////choose figter
            ///
            /// loop for looking your fighter

            bool f1 = false;
            for (int i = 0; i < chooseYourFighter.Length; i++)
            {

                if (chooseYourFighter[i] == fighter1)
                {
                    f1 = true;
                }
            }
            if (f1)
            {
                Console.WriteLine("{0} is a right Warrior", fighter1);
            }
            else
            {
                Console.WriteLine("Your fighter does not exist");
            }
            ///// Choose Weapon

            Console.WriteLine("Choose Bettle Weapon");

            /// show weapon 

            Console.WriteLine(string.Join(" ", chooseWeapon));
            
            string weapon1 = Console.ReadLine();
            string nameOfWeapon1 = weapon1;
            switch (weapon1)
            {
                case "Axe":
                    weapon1 = "3";
                    break;
                case "Sword":
                    weapon1 = "5";
                    break;
                case "Polearm":
                    weapon1 = "9";
                    break;
                default:
                    break;
            }
          int chooseWeapon1 =  int.Parse(weapon1);
            

            /// select secound figter

            Console.WriteLine("Choose Villain ");

            string fighter2 = Console.ReadLine();

            bool f2 = false;
            for (int i = 0; i < chooseYourFighter.Length; i++)
            {

                if (chooseYourFighter[i] == fighter2)
                {
                    f2 = true;
                }
            }
            if (f2)
            {
                Console.WriteLine("{0} is a Bad Guy", fighter2);
            }
            else
            {
                Console.WriteLine("Your fighter does not exist");
            }


            Console.WriteLine("Choose Bettle Weapon");
            string weapon2 = Console.ReadLine();
            string nameOfWeapon2 = weapon2;

            switch (weapon2)
            {
                case "Axe":
                    weapon2 = "3";
                    break;
                case "Sword":
                    weapon2 = "5";
                    break;
                case "Polearm":
                    weapon2 = "9";
                    break;
                default:
                    break;
            }
           int chooseWeapon2 = int.Parse(weapon2);





            Warrior goodGuy = new Warrior(fighter1, Faction.GoodGuy, chooseWeapon1, nameOfWeapon1);
            Warrior badGuy = new Warrior (fighter2, Faction.BadGuy, chooseWeapon2, nameOfWeapon2);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                     goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(200);
            }
           
        }
    }
}