using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты уравнения через пробел:");

        double[] coefficients = ReadCoefficientsFromConsole();

        try
        {
            IEquation equation = EquationManager.CreateEquation(coefficients);
            Complex[] roots = equation.FindRoots();

            Console.WriteLine("Корни уравнения:");
            foreach (Complex root in roots)
            {
                Console.WriteLine(root);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    private static double[] ReadCoefficientsFromConsole()
    {
        while (true)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            double[] coefficients = new double[parts.Length];
            bool isValid = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!double.TryParse(parts[i], out coefficients[i]))
                {
                    isValid = false;
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите коэффициенты заново:");
                    break;
                }
            }

            if (isValid)
            {
                return coefficients;
            }
        }
    }
}
