using Decorator;


IDamageable unit = new Unit();

IAbility ability = new SimpleAbility(10, TypeDamage.Physical);
ability = new AbilityDurationDamage(ability, 10, 3);

ability.ApplyDamage(unit);

Console.ReadKey();
