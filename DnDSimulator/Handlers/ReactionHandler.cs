

using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Handler
{
    public static class ReactionHandler
    {
        public static void ShowReactions(this Charakter charakter)
        {
            foreach (ReactionNames i in charakter.Reactions)
            {
                Console.Write(i);
            }
        }

        private static bool checkForBonusAction(this Charakter charakter, ReactionNames reaction)
        {
            if (charakter.Reactions.Contains(reaction))
                return true;
            return false;
        }

        public static bool CheckForOpportunityAttack(this Charakter charakter)
        {
            if (checkForBonusAction(charakter, ReactionNames.OpportunityAttack))
            {
                return true;
            }
            Console.WriteLine("Cannot attack, doesn't know how to attack");
            return false;
        }

    }
}
