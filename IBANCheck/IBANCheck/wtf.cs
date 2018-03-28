using System;
using System.Collections.Generic;
using System.Text;

namespace IBANCheck
{
    class wtf
    {
        public void nibba()
        {
            string bban = "12345600000785";
            string iban = bban + "1518";
            Console.WriteLine(iban);
            ulong Iban = Convert.ToUInt64(iban);
            int x = 0;
            Console.WriteLine(Iban);
            bool ValueNotFound = true;
            do
            {

                string IbanCopy = iban;

                Console.WriteLine("X: " + x);
                Console.WriteLine('\n');

                if (x < 10)
                {
                    IbanCopy += '0' + x.ToString();
                }
                else
                {
                    IbanCopy += x.ToString();
                }
                Iban = Convert.ToUInt64(IbanCopy);
                Console.WriteLine("Lopuksi " + Iban);
                Console.WriteLine('\n');

                if (Iban % 97 == 1)
                {
                    iban = Iban.ToString();
                    ValueNotFound = false;
                }
                Console.WriteLine("Modulo: " + Iban % 97);
                Console.WriteLine('\n');
                x++;
            }
            while (ValueNotFound);

            Console.WriteLine(iban);
        }
    }
}
