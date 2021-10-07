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
            //Console.WriteLine("enter any string");
            //var usr_input = Console.ReadLine();
            //Console.WriteLine("string in lower case " + usr_input.ToLower());
            //Console.WriteLine("string in upper case " + usr_input.ToUpper());

            //var str1 = "this_is_a_SAMple_seSSIon.";


            //Console.WriteLine("the string in correct format");
            //Console.WriteLine(char.ToUpper(str1[0]) + str1.Substring(1).ToLower());

            //Console.ReadLine();

            //var lst = str1.Split('_');
            //foreach(string str in lst)
            //{
            //    Console.Write(str);
            //}
            //Console.Read();
            //String_BCL_Examples();

            //var str2 = "I love to code in C3";
            //string[] arr = str2.Split(' ');
            //foreach (string word in arr.Reverse())
            //{ 
            //    Console.Write($"{word.Substring(0, 1).ToUpper()}{word.Substring(1)} ");


            //}
            //Console.ReadLine();

            string str4 = "this is ";
            string str5 = "sample prog";
            Console.WriteLine(string.Concat(str4,str5));

            string str7 = "          this is a sample string 2      ";
            string str6 = "//****   this is a sample string   ****//";
            char[] chartoremove = { '*', '/', ' ' };
            var trimmedString = str6.Trim();
            Console.WriteLine("Removed all whitespaces" + trimmedString);
            var trimmedstring2 = str6.Trim(chartoremove);
            Console.WriteLine("removed all char" + trimmedstring2);

            Console.ReadLine();
        }

        static void String_BCL_Examples()
        {
            List<String> lst = new List<string>();
            
            
            //compare
            string str1 = "SampleDemo";
            string str2 = "sampleDemo";

            lst.Add(str1);
            lst.Add(str1);
            
            foreach(string temp in lst)
            {
                Console.WriteLine(temp);
            }

            var arr = lst.ToArray();
            Array.Sort(arr);
            Console.WriteLine("\nAfter sorting");
            foreach (string temp in arr)
            {
                Console.WriteLine(temp);
            }


            Console.Read();

            //int res = str1.CompareTo(str2);
            //Console.WriteLine("result of string compare is:  " + res );
            ////if same, the result will be 0 
            

            //string str3 = "a";
            //string str4 = "b";

            //int res1 = str3.CompareTo(str4);
            //Console.WriteLine("result of string compare is:  " + res1);
            ////if different the result will be -1 // based on ASCII value
           

            //string str5 = "b";
            //string str6 = "a";

            //int res3 = str5.CompareTo(str6);
            //Console.WriteLine("result of string compare is:  " + res3);
            ////if different the result will be 1 // based on ASCII value // b has a great ASCII value than a
          


            //string str7 = "SampleDemo";
            //string str8 = "sampleDemo";

            //int res4 = str7.CompareTo(str8);
            //Console.WriteLine("result of string compare is:  " + res4);
            ////if same, the result will be 1
            //Console.ReadLine();
        }
    }
}
