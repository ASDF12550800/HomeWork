using System;

namespace C____Class {
    class Program { 
        static void Main(string[] args) {
            
            // 01
            {
                Console.Write("Hello World");
                Console.ReadKey();
            }
            
            Console.Clear();

            // 02
            {
                string input_1 = "", input_2 = "", str = "the string is : \n";
                // ----------------------------------- //
                Console.Write("input s1 : "); input_1 = Console.ReadLine();
                Console.Write("input s2 : "); input_2 = Console.ReadLine(); 
                // ----------------------------------- //
                Console.WriteLine(str + $"{input_1}, {input_2}");
                Console.WriteLine(str + "{0}, {1}", input_1, input_2);
                Console.WriteLine(str + input_1 + ", " + input_2);
                Console.WriteLine(new string(str + input_1 + ", " + input_2));
                Console.ReadKey();
            }

            Console.Clear();

            // 03
            {
                Console.Write("Number : ");
                int    Int   = Convert.ToInt32(Console.ReadLine());
                float  Float = Int;
                string Str   = Convert.ToString(Float);
                // --------------------------- //
                Console.WriteLine("Int    : " + Int   + " | Type : " + Int.GetType());
                Console.WriteLine("Float  : " + Float + " | Type : " + Float.GetType());
                Console.WriteLine("String : " + Str   + " | Type : " + Str.GetType());
                Console.ReadKey();
            }

            Console.Clear();

            // 04
            {
                Console.Write("input float : "); float Input_1 = Convert.ToSingle(Console.ReadLine());
                Console.Write("input float : "); float Input_2 = Convert.ToSingle(Console.ReadLine());
                // ---------------------------------------------------- //
                Console.WriteLine("+ : " + (Input_1 + Input_2));
                Console.WriteLine("- : " + (Input_1 - Input_2));
                Console.WriteLine("% : " + (Input_1 % Input_2));
                Console.WriteLine("/ : " + (Input_1 / Input_2));
                Console.WriteLine("* : " + (Input_1 * Input_2));
            }

        }
    }
}
