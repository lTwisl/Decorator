namespace Decorator
{
    internal class BaseAbility : IAbility
    {
        private float _damage;
        private TypeDamage _typeDamage;

        public BaseAbility(float damage, TypeDamage typeDamage)
        {
            _damage = damage;
            _typeDamage = typeDamage;
        }

        public virtual void ApplyDamage(IDamageable canBeDamage)
        {
            canBeDamage.TakeDamage(_damage, _typeDamage);
        }

        public virtual float GetDamage()
        {
            return _damage;
        }

        public virtual TypeDamage GetTypeDamage()
        {
            return _typeDamage;
        }
    }
}
