using System;
using System.Collections.Generic;

namespace App
{
    public static class Enums
    {
        enum Day { Mon, Tue, Wed = 100, Thu, Fri, Sat, Sun }
        public static void Usage()
        {
            List<Day> days = new List<Day> { Day.Mon, Day.Wed, Day.Sat }; 
            foreach(Day day in days)
            {
                Console.WriteLine($"{day} - {(int) day}");
            }
        }
    }
}
