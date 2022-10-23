using System;

namespace uppgift_4_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string Svar = "j";

            Console.Write("Skriv in ett tal: "); int InputTal1 = int.Parse(Console.ReadLine());

            int StörstaTal = InputTal1;

            while (Svar == "j")
            {
                Console.Write("\nVill du skriva in ett till tal? (j/n): "); Svar = Console.ReadLine();

                if (Svar == "n")
                {
                    break;
                }

                Console.Write("\nSkriv in ett tal: "); int InputTal2 = int.Parse(Console.ReadLine());

                if (InputTal2 >= InputTal1)
                {
                    InputTal2 = StörstaTal;
                }
            }
        }
    }
}
