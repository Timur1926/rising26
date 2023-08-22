using System;

namespace WorkingWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Зверь", 50, 10, 100);
            Player player2 = new Player("Пакимон", 60, 16, 80);
            player1.DisplayInfoPlayer();
            player2.DisplayInfoPlayer();
        }
    }

    class Player
    {
        private string _namePlayer;
        private int _force;
        private int _damage;
        private int _life;

        public Player() { }

        public Player(string name, int force, int damage, int life)
        {
            _namePlayer = name;
            _force = force;
            _damage = damage;
            _life = life;
        }

        public void DisplayInfoPlayer()
        {
            Console.WriteLine($"Имя игрока: {_namePlayer}\t|Сила: {_force}\t|Урон: {_damage}\t|Количество жизни: {_life}");
        }
    }
}
