using System;
using System.Globalization;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input para inserir os dados para calculos
            Console.WriteLine("Quantas pessoas serão? : ");
            float x = int.Parse(Console.ReadLine());
            double[] Doublearray = new double[x];

            //Loop até chegar no numero desejado
            for (int i = 0; i < x; i++)

            {
                //Input para inserir a altura
                Console.WriteLine("Digite a altura delas : ");
                double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Doublearray[i] = n;
            }
            //Valor final          
            double a = Doublearray.Sum();
            Console.WriteLine("A média de altura das pessoas, é  : " + (a / x));

        }
    }
}
