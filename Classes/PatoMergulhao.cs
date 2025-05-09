using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPatos.Classes
{
    internal class PatoMergulhao: Duck, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Pato-Mergulhão");
        }

        public void Fly()
        {
            Console.WriteLine("Voando como um Pato-Mergulhão!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack-quack!");
        }
    }
}
