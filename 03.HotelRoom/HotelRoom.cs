using System;

namespace _03.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nigths = int.Parse(Console.ReadLine());

            double apartamentMayOctober = 65.00;
            double studioMayOctober = 50.00;

            double apartamentJuneSeptember = 68.70;
            double studioJuneSeptember = 75.20;

            double apartamentJulyAugust = 77.00;
            double studioJulyAugust = 76.00;

            if (month == "May" || month == "October")
            {
                if (nigths > 7 && nigths <= 14)
                {
                    Console.WriteLine("Apartment: {0:0.00} lv.", apartamentMayOctober * nigths);
                    Console.WriteLine("Studio: {0:0.00} lv.", (studioMayOctober - (studioMayOctober * 0.05)) * nigths);
                }
                else if (nigths > 14)
                {
                    Console.WriteLine("Apartment: {0:0.00} lv.", (apartamentMayOctober - (apartamentMayOctober * 0.1)) * nigths);
                    Console.WriteLine("Studio: {0:0.00} lv.", (studioMayOctober - (studioMayOctober * 0.3)) * nigths);                    
                }                
                else 
                {
                    Console.WriteLine("Apartment: {0:0.00} lv.", apartamentMayOctober * nigths);
                    Console.WriteLine("Studio: {0:0.00} lv.", (studioMayOctober * nigths));
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nigths > 14)
                {
                    Console.WriteLine("Apartment: {0:0.00} lv.", (apartamentJuneSeptember - (apartamentJuneSeptember * 0.1)) * nigths);
                    Console.WriteLine("Studio: {0:0.00} lv.", (studioJuneSeptember - (studioJuneSeptember * 0.2)) * nigths);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:0.00} lv.", apartamentJuneSeptember * nigths);
                    Console.WriteLine("Studio: {0:0.00} lv.", (studioJuneSeptember * nigths));
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nigths > 14)
                {
                    Console.WriteLine("Apartment: {0:0.00} lv.", (apartamentJulyAugust - (apartamentJulyAugust * 0.1)) * nigths);
                    Console.WriteLine("Studio: {0:0.00} lv.", studioJulyAugust * nigths);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:0.00} lv.", apartamentJulyAugust * nigths);
                    Console.WriteLine("Studio: {0:0.00} lv.", studioJulyAugust * nigths);
                }
            }
        }
    }
}
