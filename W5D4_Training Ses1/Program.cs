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

            //string str4 = "this is ";
            //string str5 = "sample prog";
            //Console.WriteLine(string.Concat(str4,str5));

            //string str7 = "          this is a sample string 2      ";
            //string str6 = "//****   this is a sample string   ****//";
            //char[] chartoremove = { '*', '/', ' ' };
            //var trimmedString = str6.Trim();
            //Console.WriteLine("Removed all whitespaces" + trimmedString);
            //var trimmedstring2 = str6.Trim(chartoremove);
            //Console.WriteLine("removed all char" + trimmedstring2);

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.Date);
            //Console.WriteLine(dateTime.Month);
            //Console.WriteLine(dateTime.Year);
            //Console.WriteLine(dateTime.TimeOfDay);
            //Console.WriteLine(dateTime.ToShortDateString());
            //Console.WriteLine(dateTime.ToShortTimeString());
            //Console.WriteLine(dateTime.ToLongTimeString());
            //Console.WriteLine(dateTime.ToLongDateString());

            //Console.WriteLine(dateTime.ToString("\ndd-MM-yy"));
            //Console.WriteLine(dateTime.ToString("dd-MMM-yyyy"));
            //Console.WriteLine(dateTime.ToString("hh:mm"));
            //Console.WriteLine(dateTime.ToString("HH:mm\n"));

            //string str = "07/10/2021 23:05";

            //DateTime.TryParse(str, out DateTime datetimeObj);
            //Console.WriteLine(datetimeObj);

            //DateTime datetimeObj1 = new DateTime(2021,06,21, 22,45,10);            
            //DateTime datetimeObj2 = new DateTime(2021, 06, 21, 22, 50, 10);

            //DateTime datetimeObj1 = DateTime.Now;
            //DateTime datetimeObj2 = DateTime.Now;

            //var datetimeObj1 = DateTime.Now.ToShortDateString();
            //var datetimeObj2 = DateTime.Now.ToShortDateString();

            //var datetimeObj1 = DateTime.Now.ToShortDateString();
            //var datetimeObj2 = DateTime.Now.AddDays(10);

            //var daysInMonth = DateTime.DaysInMonth(2021, 10);
            //Console.WriteLine(daysInMonth);

            //var isLeapYear = DateTime.IsLeapYear(2020);
            //Console.WriteLine(isLeapYear);

            //Console.WriteLine(DateTime.MaxValue);
            //Console.WriteLine(DateTime.MinValue);

            //if (datetimeObj1.Equals(datetimeObj2))
            //{
            //    Console.WriteLine("they are the same");
            //}
            //else
            //{
            //    Console.WriteLine("they are different times");
            //}

            Console.WriteLine("input date");
            string datetime = Console.ReadLine();

            bool correct = DateTime.TryParse(datetime, out DateTime userdatetime);
            DateTime DateTimeNow = DateTime.Now;

            if(correct)
            {
                Console.WriteLine("valid");
                if(DateTimeNow > userdatetime)
                {
                    Console.WriteLine(DateTimeNow - userdatetime);
                    
                }

                else
                {
                    Console.WriteLine(userdatetime - DateTimeNow);
                }
                
            }

            else
            {
                Console.WriteLine("is invalid");
                return;
            }
            
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
