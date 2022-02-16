namespace M04_2
{
    internal class Bear : Monster
    {
        public Bear(int xCordinate, int yCordinate) : base(xCordinate, yCordinate)
        {
            X = xCordinate;
            Y = yCordinate;
            MonsterName = M04_2.Name.Bear;
            Damage = 2;
            Speed = 1;
        }

        public override void Move(Obstacle obst)
        {
            for (int i = 0; i < 5; i++)
            {
                if (this.X == Console.WindowWidth - 1 || this.X == obst.X - 1) break;
                this.X++;
            }

            for (int i = 0; i < 5; i++)
            {
                if (this.X == Console.WindowLeft + 1 || this.X == obst.X + 1) break;
                this.X--;
            }
        }
    }
}