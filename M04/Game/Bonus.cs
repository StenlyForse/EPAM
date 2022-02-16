namespace M04_2
{
    internal class Bonus : Object
    {
        internal int Price { get; set; }
        internal int Amount { get; set; }

        public Bonus(int xCordinate, int yCodrinate, string name, int price, int amount) : base(xCordinate, yCodrinate, name)
        {
            if (price <= 0) throw new ArgumentException("Price should be greater than 0", nameof(price));
            this.Price = price;
            if (amount <= 0) throw new ArgumentException("Price should be greater than 0", nameof(amount));
            this.Amount = amount;

            X = xCordinate;
            Y = yCodrinate;
        }
    }
}