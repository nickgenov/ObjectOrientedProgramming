using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        private const int DefaultHealerHealth = 75;
        private const int DefaultHealerDefense = 50;
        private const int DefaultHealerHealingPoints = 60;
        private const int DefaultHealerRange = 6;

        public Healer(string id, int x, int y, Team team) 
            : base(id, x, y, DefaultHealerHealth, DefaultHealerDefense, team, DefaultHealerRange)
        {
            this.HealingPoints = DefaultHealerHealingPoints;
            this.InventoryItems = new List<Item>();
        }

        public int HealingPoints { get; set; }

        public List<Item> InventoryItems { get; set; }


        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList
                .Where(t => t.Team == this.Team && t.IsAlive == true && t.Id != this.Id)
                .FirstOrDefault(t => t.HealthPoints == targetsList.Min(h => h.HealthPoints));

            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.InventoryItems.Add(item);
            base.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.InventoryItems.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
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
                "Name: {0}, Team: {2}, Health: {1}, Defense: {3}, Healing: {4}",
                this.Id,
                this.HealthPoints,
                this.Team,
                this.DefensePoints,
                this.HealingPoints);
        }
    }
}