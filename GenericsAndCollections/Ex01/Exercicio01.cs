using GenericsAndCollections.Ex01.Entities;
using GenericsAndCollections.Ex01.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndCollections.Ex01
{
    class Exercicio01
    {
        public static void Ex01()
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            string data = ProcessLogService.ReadLogFile(path);
            HashSet<User> set = ProcessLogService.BuildHashSet(data);
            Console.WriteLine("Number of diferent users: " + set.Count);
            foreach(var user in set)
            {
                Console.WriteLine(user);
            }
        }
    }
}
