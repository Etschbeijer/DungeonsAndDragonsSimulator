

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


namespace DnDSimulator.Model
{
    class GFG : IComparer<CharakterOrder>
    {
        public int Compare(CharakterOrder x, CharakterOrder y)
        {
            if (x.Initiative == 0 || y.Initiative == 0)
            {
                return 0;
            }
            // CompareTo() method 
            return y.Initiative.CompareTo(x.Initiative);
        }
    }

    public class CharakterOrder
    {
        public int Initiative { get; set; }

        public Charakter Charakter { get; set; }

        public bool CharaktersTurn { get; set; } = false;

        public CharakterOrder(Charakter charakter)
        {
            Initiative = DiceSimulator.RollD20() + charakter.Initiative;

            Charakter = charakter;
        }
    }

    public class Round /*: INotifyPropertyChanged*/
    {
        private List<CharakterOrder> particioners;

        public int Count { get; set; }

        public List<CharakterOrder> Particioners
        {
            get { return particioners; }
            set
            {
                //RaisePropertyChanged();
                particioners = value;
                //OnHappening();
            }
        }

        public int pickedParticioner { get; set; } = 0;

        public Round(List<Charakter> particioners)
        {
            Count = 1;
            Console.WriteLine(String.Format("Round {0} has started", Count));
            Particioners = new List<CharakterOrder>(particioners.Capacity);
            foreach (Charakter charakter in particioners)
                Particioners.Add(new CharakterOrder(charakter));
            Particioners.Sort(new GFG());
            RoundHandler.ShowParticioners(this);

            Charakter subscribedObject = this.PickCharakter();
            subscribedObject.Event += ProveActionEconomy;
        }

        protected void ProveActionEconomy(object sender, EventArgs e)
        {
            var charakter = this.PickCharakter();
            charakter.Event -= ProveActionEconomy;
            this.ActionEconomyHandler();
            this.PickCharakter().Event += ProveActionEconomy;
        }
    }
}




