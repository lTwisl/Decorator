namespace Decorator
{
    internal interface IAbility
    {
        public float GetDamage();
        public TypeDamage GetTypeDamage();
        public void ApplyDamage(IDamageable canBeDamage);
    }
}
