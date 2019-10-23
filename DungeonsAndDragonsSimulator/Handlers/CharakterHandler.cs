

using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Handler
{
    public static class CharakterHandler
    {
        private static void NoMoreAction(this Charakter charakter)
        {
            charakter.hasAction = false;
        }

        private static bool CheckActionLeft(this Charakter charakter)
        {
            if (charakter.hasAction)
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
            charakter.hasBonusAction = false;
        }

        private static bool CheckBonusActionLeft(this Charakter charakter)
        {
            if (charakter.hasAction)
            {
                NoMoreAction(charakter);
                return true;
            }
            Console.WriteLine("Bonusaction not possible, you have no Bonusaction left.");
            return false;
        }

        private static void NoMoreReaction(this Charakter charakter)
        {
            charakter.hasReaction = false;
        }

        private static bool CheckReactionLeft(this Charakter charakter)
        {
            if (charakter.hasAction)
            {
                NoMoreReaction(charakter);
                return true;
            }
            Console.WriteLine("Reaction not possible, you have no Reaction left.");
            return false;
        }

        public static void FinishMovement(this Charakter charakter)
        {
            charakter.finishedMovement = true;
        }

        public static void Move(this Charakter charakter, int amount)
        {
            MovementHandler.CheckMovementLeft(charakter, amount);
        }
    }
}

