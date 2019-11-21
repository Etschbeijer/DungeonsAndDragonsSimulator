

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Model
{
    public class DiceSimulator
    {
        private static readonly Random random = new Random();
        //private static readonly object syncLock = new object();
        private static int Roll(int maxValue)
        {
            //lock (syncLock)
            { // synchronize
                return random.Next(1, maxValue + 1);
            }
        }

        internal static int RollD4()
        {
            return Roll(4);
        }

        internal static List<int> RollD4(int amount)
        {
            var list = new List<int>(amount);
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
                list.Add(rnd.Next(1, 5));
            return list;
        }

        internal static int RollD6()
        {
            return Roll(6);
        }

        internal static List<int> RollD6(int amount)
        {
            var list = new List<int>(amount);
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
                list.Add(rnd.Next(1, 7));
            return list;
        }

        internal static int RollD8()
        {
            return Roll(8);
        }

        internal static List<int> RollD8(int amount)
        {
            var list = new List<int>(amount);
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
                list.Add(rnd.Next(1, 9));
            return list;
        }

        internal static int RollD10()
        {
            return Roll(10);
        }

        internal static List<int> RollD10(int amount)
        {
            var list = new List<int>(amount);
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
                list.Add(rnd.Next(1, 11));
            return list;
        }

        internal static int RollD12()
        {
            return Roll(12);
        }

        internal static List<int> RollD12(int amount)
        {
            var list = new List<int>(amount);
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
                list.Add(rnd.Next(1, 13));
            return list;
        }

        internal static int RollD20()
        {
            return Roll(20);
        }

        internal static List<int> RollD20(int amount)
        {
            var list = new List<int>(amount);
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
                list.Add(rnd.Next(1, 21));
            return list;
        }

        internal static int RollD100()
        {
            return Roll(100);
        }

        internal static List<int> RollD100(int amount)
        {
            var list = new List<int>(amount);
            var rnd = new Random();
            for (int i = 0; i < amount; i++)
                list.Add(rnd.Next(1, 101));
            return list;
        }
    }
}
