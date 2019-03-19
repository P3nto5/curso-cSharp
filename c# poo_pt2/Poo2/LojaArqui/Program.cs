using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LojaArqui.Entities;

namespace LojaArqui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\sumarry.csv";

                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fiels = line.Split(',');
                        string name = fiels[0];
                        double price = double.Parse(fiels[1]);
                        int quantity = int.Parse(fiels[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.name + "," + prod.Total().ToString());
                    }
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IOException e)
            {
                Console.WriteLine("AN error ocurred");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey(true);
        }
    }
}
