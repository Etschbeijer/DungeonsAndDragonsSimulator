using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;

namespace DnDSimulator.Handler
{
    internal static class ConditionHandler
    {
        internal static bool ContainsConditions(this Charakter charakter)
        {
            if (charakter.Conditions.Count > 0)
                return true;
            return false;
        }

        internal static bool HasAdvantage(this Charakter charakter)
        {
            return charakter.Conditions.Contains(ConditionNames.Advantage);
        }

        internal static bool HasDisAdvantage(this Charakter charakter)
        {
            return charakter.Conditions.Contains(ConditionNames.Disadvantage);
        }

        public static void ShowConditions(this Charakter charakter)
        {
            foreach (ConditionNames i in charakter.Conditions)
            {
                Console.Write(i);
            }
        }
    }
}
