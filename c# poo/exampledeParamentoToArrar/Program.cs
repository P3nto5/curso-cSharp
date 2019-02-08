using System;

namespace Value_Refrence_Type
{
    class Program
    {
        public static void Main()
        {
            int[] callingarray = { 22, 200, 25485 };
            abc(callingarray);
            Console.WriteLine("This is callingarray");
            foreach (int element in callingarray)
                Console.WriteLine(element);
            Console.ReadKey(true);
        }



        //method parameter
        static void abc(int[] calledarray)
        {
            Console.WriteLine("Method Called--------");
            foreach (int element in calledarray)
                Console.WriteLine(element);

            //Here on changing the value of elements of calledarray does't afftect the value of element of callingarray
            //if both refrences to same memory location then the value needs to change, which is not happening here
            calledarray = new int[] { 55, 54, 65 };
            foreach (int element in calledarray)
                Console.WriteLine(element);

        }

    }
}