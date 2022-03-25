using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok6
{
    class Program
    {
        enum DayOfWeek { MON, TUE, WED, THU, FRI, SAT, SUN }
        static void PrintDayOfWeek(DayOfWeek dow)
        {
            switch (dow)
            {
                case DayOfWeek.MON:
                    Console.WriteLine("Понедельник");
                    break;
                case DayOfWeek.TUE:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.WED:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.THU:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.FRI:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.SAT:
                    Console.WriteLine("Суббота");
                    break;
                case DayOfWeek.SUN:
                    Console.WriteLine("Всокресенье");
                    break;
            }
        }
        static DayOfWeek ReadDayOfWeek()
        {
            int day;
            day = int.Parse(Console.ReadLine());
            DayOfWeek dow = DayOfWeek.MON;
            switch (day)
            {
                case 1:
                    dow = DayOfWeek.MON;
                    break;
                case 2:
                    dow = DayOfWeek.TUE;
                    break;
                case 3:
                    dow = DayOfWeek.WED;
                    break;
                case 4:
                    dow = DayOfWeek.THU;
                    break;
                case 5:
                    dow = DayOfWeek.FRI;
                    break;
                case 6:
                    dow = DayOfWeek.SAT;
                    break;
                case 7:
                    dow = DayOfWeek.SUN;
                    break;
            }
            return dow;
        }
        static void Main()
        {
            DayOfWeek dow = ReadDayOfWeek();
            PrintDayOfWeek(dow);
        }
       
    }
}
