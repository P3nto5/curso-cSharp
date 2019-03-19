using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hostel.Entities;
using Hostel.Entities.Exception;

namespace Hostel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("chekc-out date must be after check");
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }
        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("Error in reservation: reservation dates for update must be future dates");
            }
            if(checkOut <= checkIn)
            {

                throw new DomainException ("error in reservation: checkout date must be after check-in date") ;
            }

            Checkin = checkIn;
            Checkout = checkOut;
           
        }
        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + "Checkin: "
                + Checkin.ToString("dd/MM/yyyy")
                + "CheckOut: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "Nights: ";

        }
    }
}
