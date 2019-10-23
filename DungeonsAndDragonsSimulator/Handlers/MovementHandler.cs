

using System;
using System.Collections.Generic;
using System.Text;
using DnDSimulator.Handler;
using DnDSimulator.Model;


namespace DnDSimulator.Handler
{
    public static class MovementHandler
    {
        internal static bool CheckMovementLeft(this Charakter charakter, int amount)
        {
            if (charakter.Movement == charakter.walked)
            {
                charakter.finishedMovement = true;
                Console.WriteLine(String.Format("{0} has no movement left.", charakter.Name));
                return false;
            }
            else
            if (charakter.walked + amount > charakter.Movement)
            {
                Console.WriteLine("{0} cannot move so far.{1}{0} can move only {2}.", charakter.Name, Environment.NewLine, charakter.Movement - charakter.walked);
                return false;
            }
            else
            {
                charakter.walked = charakter.walked + amount;
                Console.WriteLine(String.Format("{0} has moved {1}.{3}{0} has {2} movement left.", charakter.Name, amount, charakter.Movement - charakter.walked, Environment.NewLine));
                return true;
            }
        }

        public static void CheckMovement(this Charakter charakter)
        {
            if (charakter.Movement == charakter.walked)
            {
                charakter.finishedMovement = true;
                Console.WriteLine(String.Format("{0} has no movement left.", charakter.Name));
            }
            else
                Console.WriteLine(String.Format("{0} has {1} movement left.", charakter.Name, charakter.Movement - charakter.walked));
        }
    }
}   
