using Countdown;
using M07;
using MatrixSorter;

Console.WriteLine("Choose sorting strategy:");

Console.WriteLine("1 - in ascending (descending) order by sums of matrix row elements");

Console.WriteLine("2 - in ascending (descending) order by maximum element in a matrix row;");

Console.WriteLine("3 - in ascending (descending) order by minimum element in a matrix row;");

int stratNum = Convert.ToInt32(Console.ReadLine());

Sorting.SortingStrategy sortStrat = SortStrategy.SumStrategy;

switch (stratNum)
{
    case 1:
        sortStrat = SortStrategy.SumStrategy;
        break;
    case 2:
        sortStrat = SortStrategy.MaxElementStrategy;
        break;
    case 3:
        sortStrat = SortStrategy.MinElementStrategy;
        break;

    default:
        Console.WriteLine("There is no such strategy");
        Environment.Exit(0);
        break;
}

Console.WriteLine("Choose sorting order:");

Console.WriteLine("0 - Ascending, 1 - Descending");

int sortOrder = Convert.ToInt32(Console.ReadLine());

SortingOrderType sortType = SortingOrderType.Ascending;

switch (sortOrder)
{
    case 0:
        sortType = SortingOrderType.Ascending;
        break;
    case 1:
        sortType = SortingOrderType.Descending;
        break;

    default:
        Console.WriteLine("There is no such sorting type");
        Environment.Exit(0);
        break;
}

SomeDelegat sd = new SomeDelegat(SortStrategy.SumStrategy);

int[,] array = ArrayCreator.GenerateArray(5, 5);

ArrayPrinter.Print2DArray(array);

Console.WriteLine();

Sorting.Sort(sortType, array, sortStrat);

ArrayPrinter.Print2DArray(array);

CountDownEventArgs ctd = new CountDownEventArgs(5);

ctd.RaiseCountDowner();

public delegate bool SomeDelegat(int[] first, int[] second, SortingOrderType order);

public delegate string Sond();