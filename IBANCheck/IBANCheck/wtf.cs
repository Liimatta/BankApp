using System;
using System.Collections.Generic;
using System.Text;

namespace IBANCheck
{
    class wtf
    {
        public void nibba()
        {
            string bban = "123456785";
            string iban = bban + "1518";
            Console.WriteLine(iban);
            int a = 0;
            int b = 0;
            long Iban = Convert.ToInt64(iban);
            do
            {
                do
                {
                    string A = a.ToString();
                    string B = b.ToString();

                    iban = iban + A + B;
                    b++;
                }
                while (Iban % 97 != 1);
                a++;
            }
            while (Iban % 97 != 1);
            iban = Iban.ToString();
            Console.WriteLine(iban);
        }
    }
}
