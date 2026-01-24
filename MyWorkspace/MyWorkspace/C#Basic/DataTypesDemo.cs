using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.C_Basic
{
    public class DataTypesDemo
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MaxValue;
            sbyte b = 100;
            sbyte c = default(sbyte);

            byte by=byte.MaxValue;
            short s=short.MaxValue;
            ushort u=ushort.MaxValue;
            int i=int.MaxValue;
            uint ui=uint.MaxValue;
            long l=long.MaxValue;
            ulong ul=ulong.MaxValue;
            float f=float.MaxValue;
            char ch = 'A';
            string str = "abc";
            bool p=true;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(u);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(f);
            Console.WriteLine(p);
            Console.WriteLine(str);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(ui);
            Console.WriteLine(i);
            Console.WriteLine(by);
            Console.ReadKey();

        }
    }
}
