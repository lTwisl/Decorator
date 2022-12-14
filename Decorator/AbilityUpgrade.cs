namespace Decorator
{
    internal abstract class AbilityUpgrade : IAbility
    {
        protected IAbility _mainAbility;

        public AbilityUpgrade(IAbility mainAbility)
        {
            _mainAbility = mainAbility;
        }

        public virtual void ApplyDamage(IDamageable canBeDamage)
        {
            _mainAbility.ApplyDamage(canBeDamage);
        }

        public virtual float GetDamage()
        {
            return _mainAbility.GetDamage();
        }

        public virtual TypeDamage GetTypeDamage()
        {
            return _mainAbility.GetTypeDamage();
        }
    }
}
