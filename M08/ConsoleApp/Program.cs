List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine(M08.BinarySearch.DoSearch(list, 3));
Console.WriteLine(M08.BinarySearch.DoSearch(list, 8));
Console.WriteLine(M08.BinarySearch.DoSearch(arr, 1));
Console.WriteLine(M08.BinarySearch.DoSearch(arr, 10));

foreach (var sq in M08.FibonacciNumber.GenerateFibonacci(10))
    Console.WriteLine(sq);

M08.GenericQueue<int> queue = new M08.GenericQueue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

foreach (var sq in queue)
    Console.WriteLine(sq);
queue.Dequeue();

foreach (var sq in queue)
    Console.WriteLine(sq);

M08.GenericStack<string> stack = new M08.GenericStack<string>();
stack.Push("first");
stack.Push("second");
stack.Push("third");

foreach (var sq in stack)
    Console.WriteLine(sq);
stack.Pop();
foreach (var sq in stack)
    Console.WriteLine(sq);

Console.WriteLine("Polish calculation");
Console.WriteLine(M08.ReversePolishCalculator.Calculate("5 1 2 + 4 * + 3 -"));
Console.WriteLine(M08.ReversePolishCalculator.Calculate("7 2 -"));