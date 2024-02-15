using System;

class Calculator<T>
{
    public static T Add(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx + dy;
    }

    public static T Subtract(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx - dy;
    }

    public static T Multiply(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx * dy;
    }

    public static T Divide(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        if (dy == 0)
        {
            return (T)(object)"Ошибка: деление на ноль";
        }
        return dx / dy;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        dynamic num1 = Convert.ChangeType(Console.ReadLine(), typeof(double));
        Console.WriteLine("Введите первое число:");
        dynamic num2 = Convert.ChangeType(Console.ReadLine(), typeof(double));

        Console.WriteLine("Выберите операцию:");
        char operation = char.Parse(Console.ReadLine());

        dynamic result = 0;
        switch (operation)
        {
            case '+':
                result = Calculator<dynamic>.Add(num1, num2);
                break;
            case '-':
                result = Calculator<dynamic>.Subtract(num1, num2);
                break;
            case '*':
                result = Calculator<dynamic>.Multiply(num1, num2);
                break;
            case '/':
                result = Calculator<dynamic>.Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Неверная операция");
                break;
        }

        Console.WriteLine("Результат вычислений: " + result);
    }
}