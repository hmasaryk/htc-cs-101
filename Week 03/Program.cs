using System;

namespace Week_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");


            // //maske a decision

            // Console.WriteLine("What is the tempatur outside");
            // int OutsideTempature = Convert.ToInt32(Console.ReadLine());

            // //To make input statements you need both lines (14 and 15)

            // if (OutsideTempature <= 25){
            //     Console.WriteLine("Put on a Coat!");
            // }
            // else if (OutsideTempature >= 26 && OutsideTempature <=50){
            //     Console.WriteLine("Wear Sunglasses");
            // }
            // else{
            //     Console.WriteLine("Try not to die.");
            // }
            // {
                
            // }
            Console.WriteLine("Guess a number between 1 and 10");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 4){
                Console.WriteLine("Too High!");

            }
            else if (Number < 4){
                Console.WriteLine("Too Low!");
                
            }
            else{
                Console.WriteLine("Just Right!");
            }
        }
    }
}
