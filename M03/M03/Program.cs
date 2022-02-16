// See https://aka.ms/new-console-template for more information

using M03;

Console.WriteLine("Average word's length in the string above: " + AvgWordLen.AverageLength(
    "THis is Just, a    simple         string with  different>> simbols!"));

Console.WriteLine();

Console.WriteLine("Doubled char's string: " + DoubleChar.DoubleString("omg i love shrek", "o kek"));
Console.WriteLine();

SumString sumStr = new SumString("110000000000000000000", "10000000000000000000");
Console.WriteLine("Sum of two big numbers: " + sumStr.SumNumbers());
Console.WriteLine();

Console.WriteLine("Reversed string: " + ReverseString.ReverseWords("The greatest victory is that which requires no battle"));
Console.WriteLine();

Console.WriteLine("Phone numbers: ");
foreach (var phone in GetPhone.GetPhoneNumber("Txt.txt", "Numbers.txt"))
    Console.WriteLine(phone);