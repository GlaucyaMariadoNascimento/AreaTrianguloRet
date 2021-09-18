using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double medidaBase, medidaAltura, medidaArea;
            Console.Write("Base:");
            medidaBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura:");
            medidaAltura = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            medidaArea = medidaBase*medidaAltura /2;

            Console.WriteLine($"Área: {medidaArea}");
            
        }
    }
}
