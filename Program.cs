using System;

namespace TreningTimur
{
    class Program
    {
        static void Main(string[] args)
        {
            int spellMin = 1;
            int spellMax = 5;
            int theAnd = 0;
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

            while (shadowMage > theAnd && boss > theAnd)
            {
                int wizardStrike = random.Next(spellMin, spellMax);
                int bossPunch = random.Next(spellMin, spellMax);

                if (shadowMage == 100 && wizardStrike == 4)
                {
                    wizardStrike = random.Next(spellMin, spellMax);
                }

                switch (wizardStrike)
                {
                    case 1:
                        Console.WriteLine($"Mage призывает для отаки заклинание \"молния\"");
                        boss -= lightning;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                    case 2:
                        Console.WriteLine($"Mage применяет заклинание \"кусок льда\"");
                        boss -= pieceIce;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                    case 3:
                        Console.WriteLine($"Mage использует заклинание \"чёрная оспа\"");
                        boss -= smallpox;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                    case 4:
                        Console.WriteLine($"Mage использует закленание \"излечение\"");
                        shadowMage += cure;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                }

                switch (bossPunch)
                {
                    case 1:
                        Console.WriteLine($"Boss наносит удар \"молотом\"");
                        shadowMage -= hammer;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                    case 2:
                        Console.WriteLine($"Boss бъёт \"мечём\"");
                        shadowMage -= sword;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                    case 3:
                        Console.WriteLine($"Boss наносит удар \"копьём\"");
                        shadowMage -= spear;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                    case 4:
                        Console.WriteLine($"Boss бъёт \"топором\"");
                        shadowMage -= axe;
                        Console.WriteLine($"Mage = {shadowMage} | {boss} = Boss");
                        break;
                }

            }
           
            if (shadowMage > boss)
            {
                Console.WriteLine($"Победу одерживает Mage!!!!!!!!!!!!!");
            }
            
            if (boss > shadowMage)
            {
                Console.WriteLine("Победу одеоживает Boss!!!!!!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine($"Ничья !!!!!!!!!!!!!");
            }


            /*
             Легенда: Вы – теневой маг(можете быть вообще хоть кем) и у вас в арсенале есть несколько заклинаний, 
             которые вы можете использовать против Босса. Вы должны уничтожить босса и только после этого будет вам покой.

             Формально: перед вами босс, у которого есть определенное кол-во жизней и определенный ответный урон. 
             У вас есть 4 заклинания для нанесения урона боссу. Программа завершается только после смерти босса или смерти пользователя.

             Пример заклинаний
             Рашамон – призывает теневого духа для нанесения атаки (Отнимает 100 хп игроку)

             Хуганзакура (Может быть выполнен только после призыва теневого духа), наносит 100 ед. урона

             Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп. Урон босса по вам не проходит

             Заклинания должны иметь схожий характер и быть достаточно сложными, они должны иметь какие-то условия выполнения (пример - Хуганзакура). 
             Босс должен иметь возможность убить пользователя.
             */

        }
    }
}
