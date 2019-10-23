
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Model
{
    public static class BonusActions
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

        internal static void BonusAttackTarget(this Charakter charakter, Charakter target)
        {
            if (BonusActionHandler.CheckForBonusAttack(charakter))
            {
                if (checkForHit(charakter, target.ArmourClass))
                {
                    Actions.DealDamage(charakter, target, charakter.Damage);
                }
                else Console.WriteLine(String.Format("{0} missed with his attack.", charakter.Name));
            }
        }

        public static void Heal(this Charakter charakter, int amount)
        {
            if (charakter.CurrentHitPoints + amount > charakter.MaxHitPoints)
            {
                Console.WriteLine(String.Format("{0} is healed by {1} to a maximum of {2} hit-points.", charakter.Name, charakter.MaxHitPoints - amount, charakter.MaxHitPoints));
                charakter.CurrentHitPoints = charakter.MaxHitPoints;
            }
            Console.WriteLine(String.Format("{0} is healed by {1} to {2} hit-points.", charakter.Name, amount, charakter.CurrentHitPoints));
            charakter.CurrentHitPoints = charakter.CurrentHitPoints + amount;
        }

        public static void GetTemporaryHitPoints(this Charakter charakter, int amount)
        {
            Console.WriteLine(String.Format("{0} has {1} temporary hit-points.", charakter.Name, charakter.TemporaryHitPoints));
            charakter.TemporaryHitPoints = amount;
        }
    }

    public enum BonusActionNames
    {
        Attack = 0,
        Dodge = 1,
        Run = 2,
        Disengange = 3
    }
}