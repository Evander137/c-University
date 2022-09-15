using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thrash> trashList = new List<Thrash>();
            bool loop = false;
            while(!loop)
            {
                try
                {
                    trashList.Add(new Thrash());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    loop = true;
                }
            }
        }
    }
}
