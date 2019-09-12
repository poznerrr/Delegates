using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Fighter {
        public void Punch() {
            Console.WriteLine("I'm punching");
        }
        public void Kick() {
            Console.WriteLine("I'm kicking");
        }
    }

    public delegate void KomboHit();
    class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter = new Fighter();
            KomboHit hit = new KomboHit(fighter.Kick);
            hit += fighter.Punch;

        }
    }
}
