using ComposicaoEEnums.Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEEnums.Exercicio02
{
    class Ex02
    {
        public static void Exercicio02()
        {
            DateTime moment = new DateTime(2018, 6, 21, 13, 5, 44);
            string title = "Traveling to New Zealand";
            string content = "I'm going to visit this wonderful country!";
            int likes = 12;
            
            Post post1 = new Post(moment, title, content, likes);
            Comment comment = new Comment("Have a nice trip!");
            post1.AddComment(comment);
            comment = new Comment("Wow that's awesome!");
            post1.AddComment(comment);

            moment = new DateTime(2018, 7, 28, 23, 14, 19);
            title = "Good night guys";
            content = "See you tomorrow";
            likes = 5;

            Post post2 = new Post(moment, title, content, likes);
            comment = new Comment("Good night");
            post2.AddComment(comment);
            comment = new Comment("May the force be with you");
            post2.AddComment(comment);

            Console.WriteLine(post1);
            Console.WriteLine();
            Console.WriteLine(post2);
        }
    }
}
