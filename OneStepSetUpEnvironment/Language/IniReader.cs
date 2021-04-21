using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OneSetSetUpEnvironment.Language
{
    class IniReader
    {
        public IniReader(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var lines = new List<string>();

            using(var sr = new StreamReader(filePath, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine().Trim();
                    if (line != string.Empty) lines.Add(line);
                }
            }

        }
    }
}
