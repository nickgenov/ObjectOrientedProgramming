using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Mage : Character, IAttack
    {
        private const int DefaultMageHealth = 150;
        private const int DefaultMageDefense = 50;
        private const int DefaultMageAttack = 300;
        private const int DefaultMageRange = 5;

        public Mage(string id, int x, int y, Team team) 
            : base(id, x, y, DefaultMageHealth, DefaultMageDefense, team, DefaultMageRange)
        {
            this.AttackPoints = DefaultMageAttack;
            this.InventoryItems = new List<Item>();
        }

        public int AttackPoints { get; set; }

        public List<Item> InventoryItems { get; set; }


        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList
                .Where(t => t.Team != this.Team)
                .LastOrDefault(t => t.IsAlive == true);
            return target;            
        }

        public override void AddToInventory(Item item)
        {
            this.InventoryItems.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.InventoryItems.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            if (this.HealthPoints < 1)
            {
                this.HealthPoints = 1;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Name: {0}, Team: {2}, Health: {1}, Defense: {3}, Attack: {4}",
                this.Id,
                this.HealthPoints,
                this.Team,
                this.DefensePoints,
                this.AttackPoints);
        }
    }
}