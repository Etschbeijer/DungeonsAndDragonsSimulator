using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Model
{
    public class Round
    {
        public int Count { get; set; }

        public List<Charakter> Particioners { get; set; } = new List<Charakter>(0);

        public Round(List<Charakter> particioners)
        {
            Count = 1;
            Console.WriteLine(String.Format("Round {0} has started", Count));
            Particioners = particioners;
            Console.WriteLine(("The particioners are of this round are:"));
            RoundHandler.ShowParticioners(this);

        }
    }
}



