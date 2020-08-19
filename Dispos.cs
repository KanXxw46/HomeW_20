using System;
using System.Collections.Generic;
using System.Text;

namespace Hw20
{
    class Dispos
    {
        public string Name { get; set; }

        ~Dispos()
        {
            Console.Beep();
            Console.WriteLine("Disposed");
        }
    }
}
