

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;


// Contains methods to check which actions charakters can take. 
// Also contains methods to add, remove and show possible actions of the charakter.
namespace DnDSimulator.Handler
{
    public static class ActionHandler
    {
        public static void ShowActions(this Charakter charakter)
        {
            foreach (ActionNames i in charakter.Actions)
            {
                Console.WriteLine(i);
            }
        }

        public static bool CheckForAction(this Charakter charakter, ActionNames action)
        {
            if (charakter.Actions.Contains(action))
                return true;
            return false;
        }

        public static bool CheckForAttack(this Charakter charakter)
        {
            if (CheckForAction(charakter, ActionNames.Attack))
            {
                return true;
            }
            Console.WriteLine("Cannot attack, doesn't know how to attack");
            return false;
        }

        public static bool CheckForDodge(this Charakter charakter)
        {
            if (CheckForAction(charakter, ActionNames.Dodge))
                return true;
            Console.WriteLine("Cannot dodge, doesn't know how to dodge");
            return false;
        }

        public static bool CheckForRun(this Charakter charakter)
        {
            if (CheckForAction(charakter, ActionNames.Run))
            {
                return true;
            }
            Console.WriteLine("Cannot run, doesn't know how to run");
            return false;
        }

        public static bool CheckForDisengage(this Charakter charakter)
        {
            if (CheckForAction(charakter, ActionNames.Disengange))
            {
                return true;
            }
            Console.WriteLine("Cannot disengage, doesn't know how to disengage");
            return false;
        }
    }
}