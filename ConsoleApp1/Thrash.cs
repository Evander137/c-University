using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Thrash
    {
        static int szamlalo = 0;
        public Thrash()
        {
            szamlalo++;
            Console.WriteLine("Object letrehozva, Count{0}", szamlalo);
        }
        ~Thrash()
        {
            szamlalo--;
            Console.WriteLine("Object törölve, Count{0}", szamlalo);
        }
    }
}
