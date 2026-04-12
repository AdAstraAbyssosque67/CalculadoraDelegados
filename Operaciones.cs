using System;
public class Operaciones
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }

    public static int Restar(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public static int Dividir(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }

        return a / b;
    }
}
