namespace M07
{
    public static class ArrayPrinter
    {
        public static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}