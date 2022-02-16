namespace M04_2
{
    internal class Wolf : Monster
    {
        public Wolf(int xCordinate, int yCordinate) : base(xCordinate, yCordinate)
        {
            X = xCordinate;
            Y = yCordinate;
            MonsterName = M04_2.Name.Wolf;
            Damage = 1;
            Speed = 3;
        }

        public override void Move(Obstacle obst)
        {
            for (int i = 0; i < 10; i++)
            {
                if (this.Y == Console.WindowHeight - 1 || this.X == obst.Y - 1) break;
                this.Y++;
            }

            for (int i = 0; i < 10; i++)
            {
                if (this.Y == 1 || this.Y == obst.Y + 1) break;
                this.Y--;
            }
        }
    }
}