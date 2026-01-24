using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.C_Basic
{
    public class Operators
    {
        static void Main(string[] args)
        {
            int a = 12, b = 4;
            Console.WriteLine("Value of a="+a);
            Console.WriteLine("Value of b=" + b);
            Console.WriteLine();
            //Arithmatic operators(+,-,*,/,%)
            Console.WriteLine("Arithmatic operators:");

            Console.WriteLine("Addition="+(a + b));
            Console.WriteLine("Substraction=" + (a - b));
            Console.WriteLine("Multiplication="+(a*b));
            Console.WriteLine("Division="+(a/b));
            Console.WriteLine("Modulus="+(a%b));

            Console.WriteLine();
            //Assignment Operators(=,+=,-=,*=,/=,%=)

            Console.WriteLine("Assignment operators:");
            
            int c = a;
            Console.WriteLine(c);
            
            Console.WriteLine("a += b:" +( a += b));//16
            Console.WriteLine("a -= b:" + (a -= b));//12
            Console.WriteLine("a /= b:" + (a /= b));//3
            Console.WriteLine("a %= b:" + (a %= b));//3
            Console.WriteLine("a *= b:" + (a *= b));//12



            Console.WriteLine();
            //Increment/Decrement operators(++p,p++,--n,n--)
            Console.WriteLine("Increment/Decrement operators:");
            Console.WriteLine("PreIncrement(++a) of a=" + (++a));
            Console.WriteLine("PostIncrement(a++) of a=" + (a++));
            Console.WriteLine("PreDecrement(--b)of b="+(--b));
            Console.WriteLine("PostDecrement(b--)of b=" + (b--));

            Console.WriteLine();

            //Comparision Operators(<,>,<=,>=,==,!=)
            Console.WriteLine("Comparision Operators:");
                Console.WriteLine("a>b:"+(a>b));
                Console.WriteLine("a<b:"+(a<b));
                Console.WriteLine("a<=b:"+(a<=b));
                Console.WriteLine("a>=b:" + (a>= b));
                Console.WriteLine("a!=b:"+(a!=b));
                Console.WriteLine("a==b:" + (a == b));
               
                Console.WriteLine();
            //Logical Operators(&,&&,|,||,^,!)
            Console.WriteLine("Logical Operators:");
            bool b1 = a == 10 & b == 11;
            Console.WriteLine("a == 10 & b == 11:" + b1);
            bool b2 = a == 10 | b == 11;
            Console.WriteLine("a == 10 | b == 11:" + b2);
            bool b3 = a == 10 ^ b == 11;
            Console.WriteLine("a == 10 ^ b == 11:" + b3);
            Console.WriteLine("a!(b):" + !(a == b));
            Console.WriteLine("a==10 && b==11:" + (a==10 && b==11));
            Console.WriteLine("a==10 || b==11:" + (a == 10 || b == 11));

            Console.WriteLine();

            //Concatenation Operator(+)
            Console.WriteLine("Concatenation Operator:");

            Console.WriteLine("shiv" + 10);
            Console.WriteLine(1 + "shiv");
            Console.WriteLine("shiv" + "bhole");

            Console.WriteLine();
            //  Ternary operator(?:)
            Console.WriteLine("Ternary operator:");
            Console.WriteLine(a>b?true:false);

            Console.WriteLine();
            //OPerator Precedence
            int result = 4 + 5 * 4 / 2;
            Console.WriteLine(result);
        }
    } 
}
