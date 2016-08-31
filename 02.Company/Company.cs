using System;

namespace _02.Company
{
    class Company
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double learningHours = (days - days * 0.1) * 8;

            int overtime = employees * (2 * days);

            double allHours = learningHours + overtime;

            if (allHours >= hoursNeeded)
            {
                Console.WriteLine("Yes!" + ((int)allHours - hoursNeeded) + " hours left.");
            }
            else
            {
                Console.WriteLine("Not enough time!"+ (hoursNeeded - (int)allHours) + " hours needed.", );
            }
        }
    }
}
