using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateApp
{
    public class kalbasi
    {
        public int Add(string numbers)
        {
            char delimiterChar;
            string[] stringSplited;
            if (numbers.StartsWith("//"))
            {
                delimiterChar = char.Parse(numbers.Substring(2, 1));
                string newString = numbers.Substring(4, numbers.Length - 4);
                stringSplited = newString.Split(delimiterChar);
            }
            else
                stringSplited = numbers.Split(',', '\n');

            //if(stringSplited.Length > 2)
            //foreach()
            foreach(var item in stringSplited)
            {
                if (int.Parse(item) < 0)
                    throw new FormatException();

            }
            int result = 0;
            if (stringSplited.Length == 0)
                return 0;
            else if (stringSplited.Length == 1)
                return int.Parse(stringSplited[0]);
            else
            {

                foreach (var item in stringSplited)
                {
                    result += int.Parse(item);
                }
            }
            return result;
        }
    }
}