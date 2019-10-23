

using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Handler
{
    public static class RoundHandler
    {
        public static void CountUpward(this Round round)
        {
            round.Count = round.Count + 1;
            Console.WriteLine(String.Format("Round {0} has started", round.Count));
        }

        public static void ShowParticioners(this Round round)
        {
            foreach (Charakter charakter in round.Particioners)
            {
                Console.WriteLine(String.Format("{0}", charakter.Name));
            }
        }
    }
}
