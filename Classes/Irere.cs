using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPatos.Classes
{
    internal class Irere : Duck, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Irerê");
        }

        public void Fly()
        {
            Console.WriteLine("Voando como um Irerê!");
        }
    }
}
