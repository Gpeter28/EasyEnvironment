using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSetSetUpEnvironment.Utils
{
    /// <summary>
    /// This Class is use For Handle ComputerEnvironment
    /// </summary>
    static class EnvironmentVariables
    {
        public static void GetEnvironmentVariables()
        {
            //var str = Environment.GetEnvironmentVariables();

            //foreach (DictionaryEntry i in str)
            //{
            //    Console.WriteLine($"{i.Key}   {i.Value}");
            //}

            var str = Environment.GetEnvironmentVariable("path");

            var s = str.Split(';');
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }


            // This can use for Write Personal Path;

            Environment.SetEnvironmentVariable("test", "abc", EnvironmentVariableTarget.Process);
        }
        
    }
}
