using GenericsAndCollections.Ex02.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndCollections.Ex02
{
    class Exercicio02
    {
        public static void Ex02()
        {
            HashSet<Student> a = new HashSet<Student>();
            HashSet<Student> b = new HashSet<Student>();
            HashSet<Student> c = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                a.Add(new Student(int.Parse(Console.ReadLine())));
            }
            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                b.Add(new Student(int.Parse(Console.ReadLine())));
            }
            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                c.Add(new Student(int.Parse(Console.ReadLine())));
            }
            b.UnionWith(c);
            a.UnionWith(b);
            Console.WriteLine("Total students: " + a.Count);
            
        }
    }
}
