// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Performance;

C[] classes = new C[100000];
S[] structs = new S[100000];
Random random = new Random();
long fullMem;
long arrayCMem;
long arraySMem;

Process id = Process.GetProcessById(Process.GetCurrentProcess().Id);
var watch = new Stopwatch();

id.Refresh();
fullMem = id.PrivateMemorySize64;
for (int j = 0; j < classes.Length; j++)
{
    classes[j] = new C(random.Next(0, 1000));
}

id.Refresh();
arrayCMem = id.PrivateMemorySize64;
for (int i = 0; i < structs.Length; i++)
{
    structs[i] = new S(random.Next(0, 1000));
}

id.Refresh();
arraySMem = id.PrivateMemorySize64;

Console.WriteLine("Before arrays memory: " + fullMem);
Console.WriteLine("After C mem: " + arrayCMem);
Console.WriteLine("After S mem: " + arraySMem);
Console.WriteLine();
Console.WriteLine("Difference between memory after initializing first array: " + (arrayCMem - fullMem));
Console.WriteLine("Difference between memory after initializing second array: " + (arraySMem - arrayCMem));
Console.WriteLine();

watch.Start();
Array.Sort<C>(classes);
watch.Stop();
Console.WriteLine($"Execution Time of Sort classes: {watch.ElapsedMilliseconds} ms");
watch.Start();
Array.Sort<S>(structs);
watch.Stop();
Console.WriteLine($"Execution Time of Sort structs: {watch.ElapsedMilliseconds} ms");