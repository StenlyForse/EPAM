namespace M08
{
    public class ReversePolishCalculator
    {
        public static int Calculate(string str)
        {
            GenericStack<int> numberStack = new GenericStack<int>();
            int numberTwo;
            string operators = "+ - * /";
            string[] array = str.Split(" ");

            foreach (string s in array)
            {
                if (operators.Contains(s))
                {
                    string oper = s;
                    switch (oper)
                    {
                        case "+":
                            numberStack.Push(numberStack.Pop() + numberStack.Pop());
                            break;
                        case "-":
                            numberTwo = numberStack.Pop();
                            numberStack.Push(numberStack.Pop() - numberTwo);
                            break;
                        case "*":
                            numberStack.Push(numberStack.Pop() * numberStack.Pop());
                            break;
                        case "/":
                            numberTwo = numberStack.Pop();
                            numberStack.Push(numberStack.Pop() / numberTwo);
                            break;
                    }
                }
                else
                {
                    numberStack.Push(Convert.ToInt32(s));
                }
            }

            return numberStack.Pop();
        }
    }
}