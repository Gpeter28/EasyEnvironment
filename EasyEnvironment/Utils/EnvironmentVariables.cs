using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEnvironment.Utils
{
    /// <summary>
    /// This Class is use For Handle ComputerEnvironment
    /// </summary>
    static class EnvironmentVariables
    {
        public static void GetEnvironmentVariables()
        {
            var str = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);

            foreach (DictionaryEntry i in str)
            {
                Console.WriteLine($"{i.Key}   {i.Value}");
            }


            Console.WriteLine();
            var str2 = Environment.GetEnvironmentVariable("path");

            var s = str2.Split(';');
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }

        }
        // This can use for Write Personal Path;

        // Environment.SetEnvironmentVariable("test", "abc", EnvironmentVariableTarget.Process);

        public static void AddEnvironmentVariables(string name)
        {
            // Environment.SetEnvironmentVariable("test", "D:\\Git\\bin\\abccc", EnvironmentVariableTarget.User);

            var str = Environment.GetEnvironmentVariable("test", EnvironmentVariableTarget.User);
            Console.WriteLine(str);
            str += name + ";";



            //var i = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);

            //foreach (DictionaryEntry j in i)
            //{
            //    Console.WriteLine($"{j.Key}  {j.Value}");
            //}
            // T2();
        }
    }

    class EnvironmentVar
    {
        public string VariableName { get; }


        public string VariablePath { get; set; }
    }
}
