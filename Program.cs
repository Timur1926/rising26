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
            int life = 70 ;
            Random random = new Random();
            int shadowMage = 100;
            int lightning = 25;
            int pieceIce = 20;
            int smallpox = 29;
            int cure = 50;
            int lightningSpell = 1;
            int iceBlockSpell = 2;
            int blackPoxSpell = 3;
            int boss = 100;
            int hammerBlow = 1;
            int swordStrike = 2;
            int spearBlow = 3;
            int axBlow = 4;
            int hammer = 30;
            int sword = 25;
            int spear = 29;
            int axe = 35;

            while (shadowMage > number && boss > number)
            {
                int wizardStrike = random.Next(spellMin, spellMax);


                if (shadowMage == mageLife && wizardStrike == restorationOfLife)
                {
                    wizardStrike = random.Next(spellMin, spellMax);
                }

                if (wizardStrike == lightningSpell)
                {
                    Console.WriteLine($"Mage призывает для отаки заклинание \"молния\"");
                    boss -= lightning;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (wizardStrike == iceBlockSpell)
                {
                    Console.WriteLine($"Mage применяет заклинание \"кусок льда\"");
                    boss -= pieceIce;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (wizardStrike == blackPoxSpell)
                {
                    Console.WriteLine($"Mage использует заклинание \"чёрная оспа\"");
                    boss -= smallpox;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (wizardStrike == restorationOfLife && shadowMage <= life)
                {
                    Console.WriteLine($"Mage использует закленание \"востановления жизни\"");
                    shadowMage += cure;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }

                int bossPunch = random.Next(spellMin, spellMax);

                if (bossPunch == hammerBlow)
                {
                    Console.WriteLine($"Boss наносит удар \"молотом\"");
                    shadowMage -= hammer;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (bossPunch == swordStrike)
                {
                    Console.WriteLine($"Boss бъёт \"мечём\"");
                    shadowMage -= sword;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (bossPunch == spearBlow)
                {
                    Console.WriteLine($"Boss наносит удар \"копьём\"");
                    shadowMage -= spear;
                    Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                }
                else if (bossPunch == axBlow)
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
