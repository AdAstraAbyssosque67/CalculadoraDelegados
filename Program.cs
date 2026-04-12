using System;
class Program
{
    public delegate int Operacion(int a, int b);

    static void Main()
    {
        Console.WriteLine("Calculadora Con Delegados");

        Console.WriteLine("1- Sumar");
        Console.WriteLine("2- Restar");
        Console.WriteLine("3- Multiplicar");
        Console.WriteLine("4- Dividir");
        Console.WriteLine();

        Console.Write("Seleccione una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Operacion operacion = null;

        if (opcion == 1)
            operacion = Operaciones.Sumar;
        else if (opcion == 2)
            operacion = Operaciones.Restar;
        else if (opcion == 3)
            operacion = Operaciones.Multiplicar;
        else if (opcion == 4)
            operacion = Operaciones.Dividir;
