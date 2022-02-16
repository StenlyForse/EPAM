namespace M04_2
{
    internal class Player : Object
    {
        protected int HP { get; set; }
        protected int Speed { get; set; }
        protected int Score { get; set; }

        public Player(int xCordinate, int yCordinate, string name) : base(xCordinate, yCordinate, name)
        {
            X = xCordinate;
            Y = yCordinate;
        }

        public void Spawn()
        {
            X = 0;
            Y = 0;
            HP = 3;
            Speed = 1;
            Score = 0;
        }

        public void Move()
        {
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);

            switch (KeyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    X = X + 1 * Speed;
                    Console.SetCursorPosition(X, Y);
                    Console.Write("X");
                    break;
                case ConsoleKey.LeftArrow:
                    X = X - 1 * Speed;
                    Console.SetCursorPosition(X, Y);
                    Console.Write("X");
                    break;
                case ConsoleKey.UpArrow:
                    Y = Y + 1 * Speed;
                    Console.SetCursorPosition(X, Y);
                    Console.Write("X");
                    break;
                case ConsoleKey.DownArrow:
                    Y = Y - 1 * Speed;
                    Console.SetCursorPosition(X, Y);
                    Console.Write("X");
                    break;
            }
        }

        public void CollectItem(Player player, Bonus bonus)
        {
            if (bonus.X == player.X && bonus.Y == player.Y)
            {
                player.Score += bonus.Price;
                bonus.Amount--;
            }
        }

        public void GetDamage(Player player, Monster monster)
        {
            if (monster.X == player.X && monster.Y == player.Y)
            {
                player.HP -= monster.Damage;
                if (player.HP <= 0)
                    Console.WriteLine("You are dead. Your score: " + player.Score);
            }
        }
    }
}