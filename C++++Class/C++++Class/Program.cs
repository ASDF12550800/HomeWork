using System;

namespace C____Class {
    class Program {
        static void Main(string[] args) {
            Console.Write("Input : "); int Input_1 = Convert.ToInt32(Console.ReadLine());
            string All_Culc  = "" + Input_1;
            for (; ; )
            {
                Console.Write("Type : "); string Type = Console.ReadLine();
                Console.Write("Input : "); int Input_2 = Convert.ToInt32(Console.ReadLine());
                All_Culc = "(" + All_Culc + Type + Input_2 + ")";
                switch (Type)
                {
                    case "+": Input_1 = Input_1 + Input_2; break;
                    case "-" : Input_1 = Input_1 - Input_2; break;
                    case "*" : Input_1 = Input_1 * Input_2; break;
                    case "/" : Input_1 = Input_1 / Input_2; break;
                    default: break;
                }
                Console.WriteLine("Result : " + All_Culc + "=" + Input_1 + "\n\n");
                Console.Write("Continue? (Y/N) : ");
                string Answer = Console.ReadLine().ToLower();
                if (Answer == "y") continue;
                else if (Answer == "n") break;
                else {
                    Console.Write("error");
                    return;
                }
            }
            Console.Write("\n\n<Finish>");
            Console.ReadKey();
        }
    }
}
