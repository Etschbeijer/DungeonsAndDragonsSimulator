using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Model
{
    public static class Reactions
    {
        private static bool checkForHit(this Charakter charakter, int ac)
        {
            int hitRoll = Actions.calcHitRoll(charakter);
            if (hitRoll + charakter.AttackBonus >= ac)
            {
                return true;
            }
            return false;
        }

        internal static void OpportunityAttack(this Charakter charakter, Charakter target)
        {
            if (ReactionHandler.CheckForOpportunityAttack(charakter))
            {
                if (checkForHit(charakter, target.ArmourClass))
                {
                    Actions.DealDamage(charakter, target, charakter.Damage);
                }
                else Console.WriteLine(String.Format("{0} missed with his attack.", charakter.Name));
            }
        }
    }

    public enum ReactionNames
    {
        OpportunityAttack = 0
    }
}

