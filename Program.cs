using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client("localhost", 4404);
            c.Start();
            c.Send("HOLA SOY EL CLIENT");
            Console.ReadKey();
        }
    }
}
