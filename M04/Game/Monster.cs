namespace M04_2
{
    internal abstract class Monster : Object
    {
        internal int Speed { get; set; }
        internal int Damage { get; set; }
        internal Name MonsterName { get; set; }
        public Monster(int xCordinate, int yCordinate, Name name, int speed, int damage) : base(xCordinate, yCordinate)
        {
            if (speed < 0) throw new ArgumentException("Speed can not be less than 0", nameof(speed));
            this.Speed = speed;

            if (damage < 0) throw new ArgumentException("Damage can not be less than 0", nameof(damage));
            this.Damage = damage;
            this.MonsterName = name;
        }

        public Monster(int xCordinate, int yCordinate) : base(xCordinate, yCordinate)
        {
        }

        public abstract void Move(Obstacle obst);
    }
}