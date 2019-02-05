using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite o tamanho do vetor");
            n = int.Parse(Console.ReadLine());

            double[] vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a "+(i+1)+" Altura: ");
                vector[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vector[i];
            }

            double avg = sum / n;
            Console.WriteLine("Average height: " + avg.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey(true);
        }
    }
}
