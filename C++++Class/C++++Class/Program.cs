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
            }
        }
    }
}
