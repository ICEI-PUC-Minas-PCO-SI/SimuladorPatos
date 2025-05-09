using SimuladorPatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPatos.Classes
{
    internal class AlexandrePato : Duck, IKickable
    {
        public void Kick()
        {
            Console.WriteLine("Alexandre Pato chuta para o gol");
        }

        public override void Display()
        {
            Console.WriteLine("Alexandre Pato");
        }
    }
}
