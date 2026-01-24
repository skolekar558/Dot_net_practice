using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.StringAssignment
{
    public class LetterChanges
    {
        public static string LetterChangesMethod(string str)
        {
            char[] strArr = str.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] >= 67 && strArr[i] <= 122)
                {
                    strArr[i]++;

                    switch (Char.ToLower(strArr[i]))
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            strArr[i] = Char.ToUpper(strArr[i]);
                            break;
                        default:
                            break;
                    }
                }

                sb.Append(strArr[i]);
            }

            str = sb.ToString();
            return str;

        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(LetterChangesMethod(Console.ReadLine()));
        }

    
}
}
