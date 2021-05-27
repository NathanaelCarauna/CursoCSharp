using System;
using System.Collections.Generic;
using System.Text;

namespace ComportamentoDeMemoria.Exercicio01
{
    class Pensionato
    {
        public static void Alugar()
        {
            Student[] rooms = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int qteRooms = int.Parse(Console.ReadLine());

            for(int i = 0; i<qteRooms; i++)
            {
                Console.WriteLine("Rent#" + (i+1) );
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                rooms[room] = new Student { Name = name, Email = email };
                Console.WriteLine();
            }
            
            Console.WriteLine("\nBusy rooms:");
            for(int i = 0; i < rooms.Length; i++)
            {
                if(rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i]}");
                }
            }
        }
    }
}
