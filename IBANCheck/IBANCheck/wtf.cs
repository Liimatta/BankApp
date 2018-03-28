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
            long Iban = Convert.ToInt64(iban);
            string IbanCopy = iban;
            int x = 0;
            long numVal = 0;
            do
            {

                
                if(x<10)
                {
                    IbanCopy += '0' + x.ToString();
                }
                else
                {
                    IbanCopy += x.ToString();
                }
                x++;
                numVal = Int64.Parse(IbanCopy);
            }
            while (numVal % 97 != 1);

            iban = Iban.ToString();
            Console.WriteLine(iban);
        }
    }
}
