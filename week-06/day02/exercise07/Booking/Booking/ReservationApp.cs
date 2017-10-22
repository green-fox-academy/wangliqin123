using System;

namespace Booking
{
    class ReservationApp
    {
        public static void Main(string[] args)
        {
            Reservation reservation = new Reservation();

            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());
            Console.WriteLine("Booking# {0} for {1}", reservation.GetCodeBooking(), reservation.GetDowBooking());

            Console.ReadLine();
        }
    }
}