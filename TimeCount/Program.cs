using System;
using static System.Console;

namespace TimeCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(ReadLine());
            if (time > 0)
            {
                CuonDaysNtHoursNMinutes(time);
            }
            else WriteLine("Уже началось!");
        }

        static void CuonDaysNtHoursNMinutes(int time)
        {
            WriteLine();

            int days = time / 1440;
            IdentifyDay(days);

            int hours = (time - 1440 * days) / 60;
            IdentifyHour(hours);

            int minutes = time % 60;
            IdentifyMinute(minutes);
        }

        static void IdentifyDay(int day)
        {
            if (day % 10 == 1 && day != 11)
            {
                Write("{0} день\t", day);
            }
            else if (day % 10 == 2 || day % 10 == 3 || day % 10 == 4 && day != 12 && day != 13 && day != 14)
            {
                Write("{0} дня\t", day);
            }
            else Write("{0} дней\t", day);
        }

        static void IdentifyHour(int hour)
        {
            if (hour % 10 == 1 && hour != 11)
            {
                Write("{0} час\t", hour);
            }
            else if (hour % 10 == 2 || hour % 10 == 3 || hour % 10 == 4 && hour != 12 && hour != 13 && hour != 14)
            {
                Write("{0} часа\t", hour);
            }
            else Write("{0} часов\t", hour);
        }

        static void IdentifyMinute(int minute)
        {
            if (minute % 10 == 1 && minute != 11)
            {
                Write("{0} минута\t", minute);
            }
            else if (minute % 10 == 2 || minute % 10 == 3 || minute % 10 == 4 && minute != 12 && minute != 13 && minute != 14)
            {
                Write("{0} минуты\t", minute);
            }
            else Write("{0} минут\t", minute);
        }
    }
}
