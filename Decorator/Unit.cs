namespace Decorator
{
    internal class Unit : IDamageable
    {
        public void TakeDamage(float damage, TypeDamage typeDamage)
        {
            Console.WriteLine($"{GetType().Name} получил урон {damage} типа {typeDamage}");
        }
    }
}
