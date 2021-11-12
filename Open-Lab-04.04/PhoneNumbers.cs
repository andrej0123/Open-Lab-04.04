using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
                       
            string a = numbers[0].ToString();
            string b = numbers[1].ToString();
            string c = numbers[2].ToString();
            string d = numbers[3].ToString();
            string e = numbers[4].ToString();
            string f = numbers[5].ToString();
            string g = numbers[6].ToString();
            string h = numbers[7].ToString();
            string i = numbers[8].ToString();
            string j = numbers[9].ToString();

            string answer = String.Concat("(", a, b, c, ")", " ", d, e, f, "-", g, h, i, j);
            
            return answer;
          
        }
    }
}
