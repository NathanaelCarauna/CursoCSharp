using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista3
{
    class ConversorDeMoeda
    {
        public static double Converter(double cotacao, double quantidade)
        {
            return cotacao * quantidade * 1.06;
        }
    }
}
