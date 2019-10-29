

using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Handler
{
    public static class CharakterHandler
    {
        private static void NoMoreAction(this Charakter charakter)
        {
            charakter.HasAction = false;
        }

        private static bool CheckActionLeft(this Charakter charakter)
        {
            if (charakter.HasAction)
            {
                NoMoreAction(charakter);
                return true;
            }
            Console.WriteLine("Action not possible, you have no Action left.");
            return false;
        }

        public static void Attack (this Charakter charakter, Charakter target)
        {
            if (CheckActionLeft(charakter))
                charakter.AttackTarget(target);
        }

        private static void NoMoreBonusAction(this Charakter charakter)
        {
            charakter.HasBonusAction = false;
        }

        private static bool CheckBonusActionLeft(this Charakter charakter)
        {
            if (charakter.HasBonusAction)
            {
                NoMoreBonusAction(charakter);
                return true;
            }
            Console.WriteLine("Bonusaction not possible, you have no Bonusaction left.");
            return false;
        }

        private static void CheckBonusActions(this Charakter charakter)
        {
            if (charakter.BonusActions.Count < 1)
            {
                NoMoreBonusAction(charakter);
            }
        }

        private static void NoMoreReaction(this Charakter charakter)
        {
            charakter.HasReaction = false;
        }

        private static bool CheckReactionLeft(this Charakter charakter)
        {
            if (charakter.HasReaction)
            {
                NoMoreReaction(charakter);
                return true;
            }
            Console.WriteLine("Reaction not possible, you have no Reaction left.");
            return false;
        }

        public static void FinishMovement(this Charakter charakter)
        {
            charakter.FinishedMovement = true;
        }

        public static void Move(this Charakter charakter, int amount)
        {
            MovementHandler.CheckMovementLeft(charakter, amount);
        }

        private static void CheckReactions(this Charakter charakter)
        {
            if (charakter.Reactions.Count < 1)
            {
                NoMoreReaction(charakter);
            }
        }

        internal static void CheckActioneconomy(this Charakter charakter)
        {
            CheckBonusActions(charakter);
            CheckReactions(charakter);
        }
    }
}

