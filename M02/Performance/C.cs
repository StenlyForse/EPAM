namespace Performance
{
    internal class C : IComparable<C>
    {
        private int I { get; set; }

        public C(int number)
        {
            I = number;
        }

        public int CompareTo(C? intt)
        {
            return I.CompareTo(intt?.I);
        }
    }
}