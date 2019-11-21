

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
    public class Charakter /*: INotifyPropertyChanged*/
    {
        private List<ActionNames> actions = new List<ActionNames>();
        private List<ReactionNames> reactions = new List<ReactionNames>();

        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; } = 0;
        public int ArmourClass { get; set; }
        public int Initiative { get; set; }
        public int AttackBonus { get; set; }
        public int Damage { get; set; }
        public int Movement { get; set; }

        internal int walked { get; set; }

        private bool hasAction;
        private bool hasBonusAction;
        private bool hasReaction;
        private bool finishedMovement;

        public bool HasAction
        {
            get { return hasAction; }
            set
            {
                //RaisePropertyChanged();
                hasAction = value;
                OnActionChange();
            }
        }

        public bool HasBonusAction
        {
            get { return hasBonusAction; }
            set
            {
                //RaisePropertyChanged();
                hasBonusAction = value;
                OnActionChange();
            }
        }

        public bool HasReaction
        {
            get { return hasReaction; }
            set
            {
                hasReaction = value;
                //OnPropertyChanged();
            }
        }

        public bool FinishedMovement
        {
            get { return finishedMovement; }
            set
            {
                //RaisePropertyChanged();
                finishedMovement = value;
                OnActionChange();
            }
        }

        [DataType(DataType.Text)]
        internal List<ActionNames> Actions { get; set; }
        [DataType(DataType.Text)]
        internal List<BonusActionNames> BonusActions { get; set; } = new List<BonusActionNames>(0);
        [DataType(DataType.Text)]
        internal List<ReactionNames> Reactions { get; set; }
        [DataType(DataType.Text)]
        internal List<ConditionNames> Conditions { get; set; } = new List<ConditionNames>(0);

        private bool checkActioneconomy(int count)
        {
            if (count < 1)
                return false;
            return true;
        }

        #region CharakterConstruktor all parameters
        public Charakter(string name, int hitpoints, int initiative, int attackBonus, int damage, int movement,
                         int ac, List<ActionNames> actions, List<BonusActionNames> bonusActions,
                         List<ReactionNames> reactions
                        )
        {
            Name = name;
            MaxHitPoints = hitpoints;
            CurrentHitPoints = hitpoints;
            ArmourClass = ac;
            Initiative = initiative;
            AttackBonus = attackBonus;
            Damage = damage;
            Movement = movement;
            walked = 0;
            Actions = actions;
            BonusActions = bonusActions;
            Reactions = reactions;
            HasAction = checkActioneconomy(Actions.Count);
            HasBonusAction = checkActioneconomy(BonusActions.Count);
            HasReaction = checkActioneconomy(Reactions.Count);

        }
        #endregion

        #region CharakterConstruktor required parameters
        public Charakter(string name, int hitpoints, int initiative, int attack, int damage, int movement, int ac)

        {
            actions.Add(ActionNames.Attack);
            actions.Add(ActionNames.Disengange);
            actions.Add(ActionNames.Run);
            actions.Add(ActionNames.Dodge);

            reactions.Add(ReactionNames.OpportunityAttack);

            Name = name;
            MaxHitPoints = hitpoints;
            CurrentHitPoints = hitpoints;
            ArmourClass = ac;
            Initiative = initiative;
            AttackBonus = attack;
            Damage = damage;
            Movement = movement;
            walked = 0;
            Actions = actions;
            Reactions = reactions;

            HasAction = true;
            HasReaction = true;
        }
        #endregion

        public event EventHandler Event;

        internal void OnActionChange()
        {
            Event?.Invoke(this, EventArgs.Empty);
            //return RoundHandler.CheckTurnFinished(this);
        }
    }
}


