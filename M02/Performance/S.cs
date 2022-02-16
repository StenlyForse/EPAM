namespace Performance
{
    internal struct S : IComparable<S>
    {
        private int I { get; set; }

        public S(int number)
        {
            I = number;
        }

        public int CompareTo(S intt)
        {
            return I.CompareTo(intt.I);
        }
    }
}