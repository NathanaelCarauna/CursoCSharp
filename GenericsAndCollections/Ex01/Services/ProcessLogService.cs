using GenericsAndCollections.Ex01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericsAndCollections.Ex01.Services
{
    class ProcessLogService
    {
        public static string ReadLogFile(string path)
        {            
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    return sr.ReadToEnd();
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static HashSet<LogRecord> BuildHashSet(string data)
        {
            HashSet<LogRecord> hash = new HashSet<LogRecord>();
            string[] lines = data.Split('\n');
            foreach(var line in lines)
            {
                string[] lineSplit = line.Split(' ');
                string name = lineSplit[0];
                DateTime accessDate = DateTime.Parse(lineSplit[1]);
                hash.Add(new LogRecord(name, accessDate));
            }

            return hash;
        }
    }
}
