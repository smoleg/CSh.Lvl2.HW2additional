using System;

namespace HW2_additional
{
    class Program
    {
        static void Main()
        {
            Freelancer[] freelancers = new Freelancer[5];
            OfficeResident[] officestaff = new OfficeResident[5];
            Random r = new Random();

            for (int i = 0; i < freelancers.Length; i++)
            {
                freelancers[i] = new($"Фрилансер_{i}", r.Next(16, 70), r.Next(100, 3000));
                freelancers[i].CalcIncome();
            }
            for (int i = 0; i < officestaff.Length; i++)
            {
                officestaff[i] = new($"Офисный_работник_{i}", r.Next(16, 70), r.Next(50000, 200000));
                officestaff[i].CalcIncome();
            }
            Console.WriteLine("Фрилансеры:");
            PrintArray(freelancers);

            Console.WriteLine("\nЗа стабильность:");
            PrintArray(officestaff);

            Array.Sort(freelancers);
            Array.Sort(officestaff);

            Console.WriteLine("\nФрилансеры по доходу в месяц: ");
            PrintArray(freelancers);

            Console.WriteLine("\nОфисные работники по з/п: ");
            PrintArray(officestaff);
        }

        private static void PrintArray(Employee[] array)
        {
            foreach (Employee x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}
