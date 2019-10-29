

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DnDSimulator.Model;
using DnDSimulator.Handler;

namespace DnDSimulator.Model
{
    public static class Movement
    {
        internal static void Move(this Charakter charakter, int amount)
        {
            MovementHandler.CheckMovementLeft(charakter, amount);
        }
    }
}