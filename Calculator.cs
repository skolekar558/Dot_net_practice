using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Delegates :Return type,parameters
 
It is a reference type in C#
It is used to hold the method reference (address)
Delegate needs to be declared in the namespace
Syntax of delegate must match with syntax of method

Types of delegate

Singlecast delegate → one delegate hold one method ref
Multicast delegate → one delegate holds multiple method references
(method syntax & delegate syntax must be same)*/


namespace MyFirstApp
{
    // delcare delegate in the namespace

    public delegate int MyDelegate(int x, int y);

    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return (a - b);
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }
    }
}
