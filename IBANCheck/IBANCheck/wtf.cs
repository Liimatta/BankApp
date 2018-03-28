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
            long Iban = Convert.ToInt64(iban);
            
            int x = 0;
            long numVal = 0;
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
                Int64.TryParse(IbanCopy, out numVal);
                Console.WriteLine("Lopuksi " + IbanCopy);
                Console.WriteLine('\n');

                if (numVal % 97 == 1)
                {
                    iban = numVal.ToString();
                    ValueNotFound = false;
                }
                Console.WriteLine("Modulo: " + numVal % 97);
                Console.WriteLine('\n');
                x++;
            }
            while (ValueNotFound);

            Console.WriteLine(iban);
        }
    }
}
