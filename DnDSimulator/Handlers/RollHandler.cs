using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;

namespace DnDSimulator.Handler
{
    public static class RollHandler
    {
        public static int RollDisadvantage()
        {
            List<int> rolls = DiceSimulator.RollD20(2);
            rolls.Sort();
            return rolls[0];
        }

        public static int RollAdvantage()
        {
            List<int> rolls = DiceSimulator.RollD20(2);
            rolls.Sort();
            return rolls[1];
        }
    }
}
