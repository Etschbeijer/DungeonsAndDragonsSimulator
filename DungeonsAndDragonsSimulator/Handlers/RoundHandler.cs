

using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDSimulator.Model;
using DnDSimulator.Handler;
using System.Runtime.CompilerServices;


namespace DnDSimulator.Handler
{
    public static class RoundHandler
    {
        public static void CountUpward(this Round round)
        {
            round.Count = round.Count + 1;
            Console.WriteLine(String.Format("Round {0} has started", round.Count));
        }

        public static void ShowParticioners(this Round round)
        {
            Console.WriteLine(("The particioners of this round are:"));
            foreach (CharakterOrder charakter in round.Particioners)
            {
                Console.WriteLine(String.Format("{0}", charakter.Charakter.Name));
            }
        }

        internal static void TurnStart(this Round round)
        {
            Charakter charakter = round.PickCharakter();

            charakter.HasAction = true;
            charakter.HasBonusAction = true;
            charakter.HasReaction = true;
            charakter.walked = 0;
            charakter.FinishedMovement = false;
            CharakterHandler.CheckActioneconomy(charakter);
        }

        internal static void TurnEnd(this Round round)
        {
            Charakter charakter = round.PickCharakter();

            charakter.HasAction = false;
            charakter.HasBonusAction = false;
            charakter.FinishedMovement = true;
            UnpickCharakter(round);
        }

        public static Charakter PickCharakter(this Round round)
        {
            round.Particioners[round.pickedParticioner].CharaktersTurn = true;
            return round.Particioners[round.pickedParticioner].Charakter;
        }

        public static void UnpickCharakter (this Round round)
        {
            round.Particioners[round.pickedParticioner].CharaktersTurn = false;
        }

        public static bool PickedCharakter(this Round round)
        {
            return round.Particioners[round.pickedParticioner].CharaktersTurn;
        }

        public static void CharakterTurn(this Round round)
        {
            round.Particioners[round.pickedParticioner].CharaktersTurn = true;
        }

        private static void resetPickOrder(this Round round)
        {
            round.pickedParticioner = 0;
            CountUpward(round);
        }

        public static void NextCharakter(this Round round)
        {
            if (round.pickedParticioner + 1 >= round.Particioners.Count)
            {
                resetPickOrder(round);
            }
            else round.pickedParticioner = round.pickedParticioner + 1;
        }

        internal static bool CheckTurnFinished(Charakter charakter)
        {
            if (!charakter.HasAction && !charakter.HasBonusAction && charakter.FinishedMovement)
            {
                Console.WriteLine("{0} has finished his turn.", charakter.Name);
                return true;
            }
            return false;
        }

        internal static void NextTurn(this Round round)
        {
            TurnEnd(round);
            NextCharakter(round);
            TurnStart(round);
            Console.WriteLine(String.Format("{0} starts the turn.", PickCharakter(round).Name));
        }

        internal static void ActionEconomyHandler(this Round round)
        {
            var charakter = round.PickCharakter();

            if (CheckTurnFinished(charakter))
                NextTurn(round);
        }
    }
}
