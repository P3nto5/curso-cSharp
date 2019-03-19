using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\data.txt";
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            /*
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            */
            Console.ReadKey(true);
        }
    }
}
