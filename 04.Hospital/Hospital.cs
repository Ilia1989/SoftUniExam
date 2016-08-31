using System;

namespace _04.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int patient = 0;
            int doctors = 7;

            int treated = 0;
            int untreated = 0;

            for (int i = 1; i < days+1; i++)
            {
                patient = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreated > treated)
                {
                    doctors += 1;                    
                }
                if (patient == doctors)
                {
                    treated += doctors;
                }
                else if (patient > doctors)
                {
                    treated += doctors;
                    untreated += patient - doctors;
                }
                else if (patient < doctors)
                {
                    treated += patient;
                }                
            }

            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
