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
            Console.WriteLine("Recko , Bane , Lalat, Dragan");
            string fighter1 =  Console.ReadLine(); ///////
            /////
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

            foreach (var item in chooseWeapon)
            {
                Console.WriteLine(item);
            }
            
            string weapon1 = Console.ReadLine();

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

          


          


            Warrior goodGuy = new Warrior(fighter1, Faction.GoodGuy, weapon1);
            Warrior badGuy = new Warrior (fighter2, Faction.BadGuy, weapon2);

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