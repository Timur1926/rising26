using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int spellMin = 1;
            int spellMax = 5;
            int number = 0;
            int mageLife = 100;
            int restorationOfLife = 4;
            Random random = new Random();
            int shadowMage = 100;
            int lightning = 25;
            int pieceIce = 20;
            int smallpox = 29;
            int cure = 50;
            int boss = 100;
            int hammer = 30;
            int sword = 25;
            int spear = 29;
            int axe = 35;

            while (shadowMage > number && boss > number)
            {
                int wizardStrike = random.Next(spellMin, spellMax);
                int bossPunch = random.Next(spellMin, spellMax);

                if (shadowMage == mageLife && wizardStrike == restorationOfLife)
                {
                    wizardStrike = random.Next(spellMin, spellMax);
                }

                if (wizardStrike == 1)
                {
                    Console.WriteLine($"Mage призывает для отаки заклинание \"молния\"");
                    boss -= lightning;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (wizardStrike == 2)
                {
                    Console.WriteLine($"Mage применяет заклинание \"кусок льда\"");
                    boss -= pieceIce;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (wizardStrike == 3)
                {
                    Console.WriteLine($"Mage использует заклинание \"чёрная оспа\"");
                    boss -= smallpox;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (wizardStrike == 4)
                {
                    Console.WriteLine($"Mage использует закленание \"востановления жизни\"");
                    shadowMage += cure;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }

                if (bossPunch == 1)
                {
                    Console.WriteLine($"Boss наносит удар \"молотом\"");
                    shadowMage -= hammer;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (bossPunch == 2)
                {
                    Console.WriteLine($"Boss бъёт \"мечём\"");
                    shadowMage -= sword;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (bossPunch == 3)
                {
                    Console.WriteLine($"Boss наносит удар \"копьём\"");
                    shadowMage -= spear;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (bossPunch == 4)
                {
                    Console.WriteLine($"Boss бъёт \"топором\"");
                    shadowMage -= axe;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }

            }
           
            if (shadowMage > boss)
            {
                Console.WriteLine($"Победу одерживает Mage!!!!!!!!!!!!!");
            }
            else if (boss > shadowMage)
            {
                Console.WriteLine("Победу одеоживает Boss!!!!!!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine($"Ничья !!!!!!!!!!!!!");
            }

        }
    }
}
