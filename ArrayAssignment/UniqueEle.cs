using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyFirstApp.ArrayAssignment
{
    public  class UniqueEle
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 ,5,5,7,7,9,9};
            var uniqueele = a.Distinct();
            foreach ( var ele in uniqueele )
            {
                Console.WriteLine(ele);
            }
        }

    }
}
