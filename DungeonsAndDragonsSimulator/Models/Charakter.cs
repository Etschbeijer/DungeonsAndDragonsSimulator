using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDSimulator.Model;
using DnDSimulator.Handler;


namespace DnDSimulator.Model
{
    public class Charakter
    {
        private List<ActionNames>   actions     = new List<ActionNames>();
        private List<ReactionNames> reactions   = new List<ReactionNames>();

        public      int     Id                  { get; set; }
        public      string  Name                { get; set; }
        public      int     MaxHitPoints        { get; set; }
        public      int     CurrentHitPoints    { get; set; }
        public      int     TemporaryHitPoints  { get; set; } = 0;
        public      int     ArmourClass         { get; set; }
        public      int     Initiative          { get; set; }
        public      int     AttackBonus         { get; set; }
        public      int     Damage              { get; set; }
        public      int     Movement            { get; set; }

        internal    int     walked              { get; set; } = 0;
        internal    bool    hasAction           { get; set; } = true;
        internal    bool    hasBonusAction      { get; set; } = true;
        internal    bool    hasReaction         { get; set; } = true;
        internal    bool    finishedMovement    { get; set; } = false;

        [DataType(DataType.Text)]
        internal List<ActionNames>      Actions       { get; set; }
        [DataType(DataType.Text)]
        internal List<BonusActionNames> BonusActions  { get; set; } = new List<BonusActionNames>(0);
        [DataType(DataType.Text)]
        internal List<ReactionNames>    Reactions     { get; set; }
        [DataType(DataType.Text)]
        internal List<ConditionNames>   Conditions    { get; set; } = new List<ConditionNames>(0);

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
            Actions = actions;
            BonusActions = bonusActions;
            Reactions = reactions;
        }

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
            Actions = actions;
            Reactions = reactions;
        }
    }    
}


