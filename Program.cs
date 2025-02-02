using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть перше число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть дію (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

        int result = 0;

        try
        {
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("При діленні не можна використовувати 0");                                           
                    }
                    result = num1 / num2;
                    break;
            }
        }

        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Результат: " + result);
    }
}
