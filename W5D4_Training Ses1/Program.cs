using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5D4_Training_Ses1
{
    class Program
    {
        static void Main(string[] args)
        {
            String_BCL_Examples();
        }

        static void String_BCL_Examples()
        {
            //compare
            string str1 = "SampleDemo";
            string str2 = "SampleDemo";

            int res = str1.CompareTo(str2);
            Console.WriteLine("result of string compare is:  " + res );
            //if same, the result will be 0 
            

            string str3 = "a";
            string str4 = "b";

            int res1 = str3.CompareTo(str4);
            Console.WriteLine("result of string compare is:  " + res1);
            //if different the result will be -1 // based on ASCII value
           

            string str5 = "b";
            string str6 = "a";

            int res3 = str5.CompareTo(str6);
            Console.WriteLine("result of string compare is:  " + res3);
            //if different the result will be 1 // based on ASCII value // b has a great ASCII value than a
          


            string str7 = "SampleDemo";
            string str8 = "sampleDemo";

            int res4 = str7.CompareTo(str8);
            Console.WriteLine("result of string compare is:  " + res4);
            //if same, the result will be 1
            Console.ReadLine();
        }
    }
}
