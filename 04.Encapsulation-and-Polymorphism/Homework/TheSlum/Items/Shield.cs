namespace TheSlum.Items
{
    public class Shield : Item
    {
        private const int ShieldHealthEffect = 0;
        private const int ShieldDefenseEffect = 0;
        private const int ShieldAttackEffect = 75;

        public Shield(string id) 
            : base(id, ShieldHealthEffect, ShieldDefenseEffect, ShieldAttackEffect)
        {
        }
    }
}