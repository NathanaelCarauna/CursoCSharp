using System;
using System.Collections.Generic;
using System.Text;

namespace ComportamentoDeMemoria.Exercicio01
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
