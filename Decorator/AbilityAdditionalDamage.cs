namespace Decorator
{
    internal class AbilityAdditionalDamage : AbilityUpgrade
    {
        private float _damage;
        private TypeDamage _typeDamage;
        public AbilityAdditionalDamage(IAbility mainAbility, float damage, TypeDamage typeDamage) : base(mainAbility)
        {
            _damage = damage;
            _typeDamage = typeDamage;
        }

        public override void ApplyDamage(IDamageable canBeDamage)
        {
            base.ApplyDamage(canBeDamage);

            canBeDamage.TakeDamage(_damage, _typeDamage);
        }
    }
}
