using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hostel.Entities;
using Hostel.Entities.Exception;

namespace Hostel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy)");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                //Reservation reservation = new Reservation(number, checkIn, checkOut);


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation");

                Console.WriteLine("Check-in date (dd/MM/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy)");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDate(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);


            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: "+ e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected" + e.Message);
            }
            Console.ReadKey(true);
            
        }
    }
}
