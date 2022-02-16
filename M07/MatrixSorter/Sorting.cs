namespace MatrixSorter
{
    public class Sorting
    {
        public delegate bool SortingStrategy(int[] first, int[] second, SortingOrderType order);

        public static int[,] Sort(SortingOrderType order, int[,] arr, SortingStrategy sortingStrategyDelegate)
        {
            int[] firstRow = new int[arr.GetLength(1)];
            int[] secondRow = new int[arr.GetLength(1)];

            for (int z = 0; z < arr.GetLength(0); z++)
            {
                for (int i = 0; i < arr.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        firstRow[j] = arr[i, j];
                        secondRow[j] = arr[i + 1, j];
                    }

                    if (sortingStrategyDelegate.Invoke(firstRow, secondRow, order))
                    {
                        int[] tmp = firstRow;
                        firstRow = secondRow;
                        secondRow = tmp;
                    }

                    for (int k = 0; k < arr.GetLength(1); k++)
                    {
                        arr[i, k] = firstRow[k];
                        arr[i + 1, k] = secondRow[k];
                    }
                }
            }

            return arr;
        }
    }
}