using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a Java program to input any alphabet and check whether it is vowel or consonant 
namespace MyWorkspace.LoopingAssignment
{
    public class ConsonentVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabhets:");
            char ch = Console.ReadLine()[0];
            if((ch =='a' || ch=='e'|| ch=='i'||ch=='o'||ch=='u')||(ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'))
            {
                Console.WriteLine("character is a vowel");
            }
            else
            {
                Console.WriteLine("character is a consonent");
            }

        }
    }
}
