namespace M08
{
    public class FibonacciNumber
    {
        public static IEnumerable<int> GenerateFibonacci(int position)
        {
            for (int i = 0; i < position; i++)
            {
                yield return Fib(i);
            }
        }

        private static int Fib(int n)
        {
            return n > 1 ? Fib(n - 1) + Fib(n - 2) : n;
        }
    }
}