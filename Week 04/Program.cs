using System;

namespace Week_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("What day of the week is it? (mon,tue,wed,thu,fri,sat,sun) ");
        string day = Console.ReadLine();

        Console.WriteLine("What time is it (use military time)? ");
        int time = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("How many hours are you going to be parked here? ");
        int length = Convert.ToInt32(Console.ReadLine());

        if ((time >= 4 && time<= 7) || (time >= 0 && time<=7 && day == "sat")||(time >= 0 && time<=7 && day == "sun")) {
            Console.WriteLine("DO NOT PARK HERE! YOUR CAR WILL BE TOWED!!!");
        }
        
        else if ((day == "mon" || day == "tue" || day == "wed" || day == thu) && ((time= 22 && length <=4) || (time= 23 && length <=3) )
    
        }
    }
}
