namespace MatrixSorter
{
    public static class SortStrategy
    {
        public static bool SumStrategy(int[] firstArr, int[] secondArr, SortingOrderType sortingOrder)
        {
            int sum1 = firstArr.Sum();
            int sum2 = secondArr.Sum();

            return (sum1 > sum2 && sortingOrder == SortingOrderType.Ascending) || (sum1 < sum2 && sortingOrder == SortingOrderType.Descending);
        }

        public static bool MaxElementStrategy(int[] firstArr, int[] secondArr, SortingOrderType sortingOrder)
        {
            int max1 = firstArr.Max();
            int max2 = secondArr.Max();

            return (max1 > max2 && sortingOrder == SortingOrderType.Ascending) || (max1 < max2 && sortingOrder == SortingOrderType.Descending);
        }

        public static bool MinElementStrategy(int[] firstArr, int[] secondArr, SortingOrderType sortingOrder)
        {
            int min1 = firstArr.Min();
            int min2 = secondArr.Min();

            return (min1 < min2 && sortingOrder == SortingOrderType.Ascending) || (min1 > min2 && sortingOrder == SortingOrderType.Descending);
        }
    }
}