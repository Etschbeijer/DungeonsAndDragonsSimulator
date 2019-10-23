

using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Model
{
    public static class Actions
    {
        internal static int calcHitRoll(this Charakter charakter)
        {
            if (charakter.HasAdvantage())
            {
                return RollHandler.RollAdvantage();
            }
            if (charakter.HasDisAdvantage())
            {
                return RollHandler.RollDisadvantage();
            }
            return DiceSimulator.RollD20();
        }

        internal static bool checkForHit(this Charakter charakter, int ac)
        {
            int hitRoll = calcHitRoll(charakter);
            if (hitRoll + charakter.AttackBonus >= ac)
            {
                return true;
            }
            return false;
        }

        private static void TakeDamage(this Charakter charakter, int amount)
        {
            var damage = charakter.TemporaryHitPoints - amount;
            if (damage < 0)
            {
                charakter.CurrentHitPoints = charakter.CurrentHitPoints + damage;
                Console.WriteLine(String.Format("{0} takes {1} points damage.", charakter.Name, amount));
            }
            if (damage > 0)
            {
                charakter.TemporaryHitPoints = damage;
                Console.WriteLine(String.Format("{0} takes {1} points damage. {0} has {2} temporary hit points left.", charakter.Name, amount, charakter.TemporaryHitPoints));
            }
            if (charakter.CurrentHitPoints <= 0)
            {
                Console.WriteLine(String.Format("{0} dropped below 0 HitPoints! {0} is unconcious.", charakter.Name));

            }
        }

        internal static void DealDamage(this Charakter charakter, Charakter target, int amount)
        {
            var damage = target.TemporaryHitPoints - amount;
            if (damage < 0)
            {
                target.CurrentHitPoints = target.CurrentHitPoints + damage;
                Console.WriteLine(String.Format("{0} deals {1} points damage to {2}.", charakter.Name, amount, target.Name));
            }
            if (damage > 0)
            {
                target.TemporaryHitPoints = damage;
                Console.WriteLine(String.Format("{0} deals {1} points damage to {2}.", charakter.Name, amount, target.Name));
            }
            if (target.CurrentHitPoints <= 0)
                Console.WriteLine(String.Format("{0} dropped below 0 HitPoints! {0} is unconcious.", target.Name));
        }

        internal static void AttackTarget(this Charakter charakter, Charakter target)
        {
            if (ActionHandler.CheckForAttack(charakter))
            {
                if (checkForHit(charakter, target.ArmourClass))
                {
                    DealDamage(charakter, target, charakter.Damage);
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
            else
                Console.WriteLine(String.Format("{0} is healed by {1} to {2} hit-points.", charakter.Name, amount, charakter.CurrentHitPoints));
                charakter.CurrentHitPoints = charakter.CurrentHitPoints + amount;
        }

        public static void GetTemporaryHitPoints(this Charakter charakter, int amount)
        {
            Console.WriteLine(String.Format("{0} has {1} temporary hit-points.", charakter.Name, charakter.TemporaryHitPoints));
            charakter.TemporaryHitPoints = amount;
        }

        public class Moving
        {
            public int movement { get; set; }

            //if (charakter.walked + amount > charakter.Movement)
            //    Console.WriteLine("You would exceed the movement capacities of your charakter.");
            //charakter.walked = charakter.walked + amount;
            //Console.WriteLine(String.Format("You have {0} feet left for movement.", (charakter.Movement - charakter.walked).ToString()));
        }

    }

    public enum ActionNames
    {
        Attack      = 0,
        Dodge       = 1,
        Run         = 2,
        Disengange  = 3
    }
}


