using System;

namespace BBANCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            BBAN bban = new BBAN("Bban");
            bban.Bbantran();
            Console.ReadKey();
            
        }
    }
}
