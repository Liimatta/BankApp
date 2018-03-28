using System;
using System.Collections.Generic;
using System.Text;

namespace IBANCheck
{
    class IBAN
    {

        public string bban;
        public IBAN(string Bban)
        {
            bban = Bban;
        }


        public string Bbantran()
        {
            Console.WriteLine("Input account number:");
            string bban = Console.ReadLine();
            var dashremove = new string[] { "-", " ", ",", "." };
            foreach (var d in dashremove)
            {
                bban = bban.Replace(d, string.Empty);
            }
            if (bban[0] == '1' || bban[0] == '2' || bban[0] == '3' || bban[0] == '6' || bban[0] == '8')
            {
                int zp = 6;
                for (int length = bban.Length; length < 14; length++)
                {
                    bban = bban.Insert(zp, "0");
                }
                Console.WriteLine(bban);

            }



            if (bban[0] == '4' || bban[0] == '5')
            {
                int zp = 7;
                for (int length = bban.Length; length < 14; length++)
                {
                    bban = bban.Insert(zp, "0");
                }
                Console.WriteLine(bban);
            }
            string checkbban = bban.Substring(0, 13);
            string checkbban2 = bban.Substring(13, 1);
            Console.WriteLine(checkbban);
            Console.WriteLine(checkbban2);

            int l = 0;
            for (int i = 12; i >= 0; i--)
            {
                int k = (int)Char.GetNumericValue(checkbban[i]);
                if (i % 2 == 0) k *= 2;
                if (k >= 10)
                {
                    String T = k.ToString();
                    int s1 = (int)Char.GetNumericValue(T[0]);
                    int s2 = (int)Char.GetNumericValue(T[1]);
                    l += (s1 + s2);

                }
                else
                {
                    l += k;
                }
                Console.WriteLine(l);
            }
            int n = l;
            Console.WriteLine(l);

            string checker = l.ToString(); //checker = 35, muuntaa l:n stringiksi
            Console.WriteLine(checker.Length);
            int c2 = (int)Char.GetNumericValue(checker[checker.Length - 1]);
            Console.WriteLine(c2);
            int c3 = 10 - c2;
            l += c3;
            Console.WriteLine(l);

            int checkbban20 = (int)Char.GetNumericValue(checkbban2[0]);
            if (n + checkbban20 == l)
                Console.WriteLine("BBAN OK");
            else
                Console.WriteLine("Tilinumero virheellinen");
            Console.WriteLine(bban);
            Console.ReadKey();

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


            return bban;

        }

        
    }
}

