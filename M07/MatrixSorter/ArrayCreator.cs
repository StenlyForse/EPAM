namespace M07
{
    public static class ArrayCreator
    {
        public static int[,] GenerateArray(int rowsNum, int columnNum)
        {
            if (rowsNum <= 0 || columnNum <= 0)
                throw new ArgumentException("rowsNum or columnNum can not be less or equal to zero");

            int[,] array = new int[rowsNum, columnNum];
            Random random = new Random();
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < columnNum; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }

            return array;
        }
    }
}