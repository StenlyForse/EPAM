namespace ArrayHelper
{
    public class TwoDimArrSumBase
    {
        public int Sum(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > 0)
                        sum += array[i, j];
                }
            }

            return sum;
        }
    }
}