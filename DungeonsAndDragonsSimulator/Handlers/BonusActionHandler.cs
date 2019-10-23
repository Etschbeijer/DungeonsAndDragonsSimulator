

using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Handler
{
    public static class BonusActionHandler
    {
        public static void ShowBonusActions(this Charakter charakter)
        {
            foreach (BonusActionNames i in charakter.BonusActions)
            {
                Console.Write(i);
            }
        }

        private static bool checkForBonusAction(this Charakter charakter, BonusActionNames bonusAction)
        {
            if (charakter.BonusActions.Contains(bonusAction))
                return true;
            return false;
        }

        public static bool CheckForBonusAttack(this Charakter charakter)
        {
            if (checkForBonusAction(charakter, BonusActionNames.Attack))
            {
                return true;
            }
            Console.WriteLine("Cannot attack, doesn't know how to attack");
            return false;
        }

        public static bool CheckForDodge(this Charakter charakter)
        {
            if (checkForBonusAction(charakter, BonusActionNames.Dodge))
                return true;
            Console.WriteLine("Cannot dodge, doesn't know how to dodge");
            return false;
        }

        public static bool CheckForRun(this Charakter charakter)
        {
            if (checkForBonusAction(charakter, BonusActionNames.Run))
            {
                return true;
            }
            Console.WriteLine("Cannot run, doesn't know how to run");
            return false;
        }

        public static bool CheckForDisengage(this Charakter charakter)
        {
            if (checkForBonusAction(charakter, BonusActionNames.Disengange))
            {
                return true;
            }
            Console.WriteLine("Cannot disengage, doesn't know how to disengage");
            return false;
        }
    }
}
