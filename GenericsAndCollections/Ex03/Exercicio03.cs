using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericsAndCollections.Ex03
{
    class Exercicio03
    {
        public static void Ex03()
        {
            Dictionary<string, int> candidatosDic = new Dictionary<string, int>();

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            
            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] line = sr.ReadLine().Split(',');
                    if (candidatosDic.ContainsKey(line[0]))
                    {
                        candidatosDic[line[0]] += int.Parse(line[1]);
                    }
                    else
                    {
                        candidatosDic[line[0]] = int.Parse(line[1]);
                    }
                }
            }

            foreach(var c in candidatosDic)
            {
                Console.WriteLine(c.Key + ": " + c.Value);
            }
        }
    }
}
