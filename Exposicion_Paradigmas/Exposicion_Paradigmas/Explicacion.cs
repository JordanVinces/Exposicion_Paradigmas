using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exposicion_Paradigmas
{
    internal class Explicacion
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 5, 6, 3, 1, 3, 8, 10};
            
            //Paradigma Imperativo
            var max5 = new List<int>();

            foreach(var num in numbers)
            {
                if(num > 5)
                    max5.Add(num*10);
            }

            //Programacion Funcional y Paradigma Declarativo 
            var max5D = numbers.Where(d => d > 5).Select(d=>d*10).ToList();
        }

    }
}
