namespace M04_2
{
    internal class Tiger : Monster
    {
        public Tiger(int xCordinate, int yCordinate) : base(xCordinate, yCordinate)
        {
            X = xCordinate;
            Y = yCordinate;
            MonsterName = M04_2.Name.Tiger;
            Damage = 0;
            Speed = 2;
        }

        public override void Move(Obstacle obst)
        {
            for (int i = 0; i < 20; i++)
            {
                if (this.X == Console.WindowWidth - 1 || this.Y == Console.WindowHeight - 1 || this.X == obst.X - 1 || this.X == obst.Y - 1) break;
                this.X++;
                this.Y++;
            }

            for (int i = 0; i < 20; i++)
            {
                if (this.X == 1 || this.Y == 1 || this.X == obst.X + 1 || this.X == obst.Y + 1) break;
                this.X--;
                this.Y--;
            }
        }
    }
}