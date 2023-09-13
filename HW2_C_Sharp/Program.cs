using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4:
            Replacement replacement = new Replacement();
            replacement.SetNums(744839);
            replacement.ChangePlaces(3, 6);
            Console.WriteLine(replacement.GetNums() + "\n\n\n");

            // Task 5:
            Console.WriteLine("Введите дату в формате день/месяц/год (например, 30/12/2023):");
            string tempDate = Console.ReadLine();

            if (DateTime.TryParseExact(tempDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                string dayWeek = date.ToString("dddd", CultureInfo.GetCultureInfo("ru-RU"));
                Console.WriteLine($"День недели: {dayWeek}");

                string month = date.ToString("MMMM", CultureInfo.GetCultureInfo("ru-RU"));
                Console.WriteLine($"Месяц: {month}");
            }
            else
            {
                Console.WriteLine("Error/ Task 5");
            }
            Console.ReadLine();

            // Task 7:
            int start;
            int finish;
            Console.Write("Введите начальное число диапазона: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите конечное число диапазона: ");
            finish = Convert.ToInt32(Console.ReadLine());
            if(start > finish)
            {
                int tempNum = start;
                start = finish;
                finish = tempNum;
            }
            Console.WriteLine($"Все парные числа в диапазоне от {start} до {finish}: ");
            while(start < finish)
            {
                if (start % 2 == 0)
                {
                    Console.Write(start + " ");
                }
                start++;
            }
            Console.ReadLine();

        }
    }
}
