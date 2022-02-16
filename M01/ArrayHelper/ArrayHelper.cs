namespace ArrayHelper
{
    public class BubbleSort
    {
        public int[] Array { get; private set; }

        public int Asc { get; private set; }

        public enum SortOrder
        {
            Ascending,
            Descending
        }

        public SortOrder Order { get; private set; }

        public BubbleSort(int[] array, SortOrder soo)
        {
            Array = array;
            Order = soo;
        }

        public int[] Sort()
        {
            int temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    var sortCondition = Order == SortOrder.Ascending
                ? Array[j] > Array[j + 1]
                : Array[j] < Array[j + 1];
                    if (sortCondition)
                    {
                        temp = Array[j + 1];
                        Array[j + 1] = Array[j];
                        Array[j] = temp;
                    }
                }
            }

            return Array;
        }
    }
}