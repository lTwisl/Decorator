using Decorator;


IDamageable unit = new Unit();

IAbility ability = new BaseAbility(10, TypeDamage.Physical);

ability = new AbilityAdditionalDamage(ability, 5, TypeDamage.Magical);
ability = new AbilityAdditionalDamage(ability, 7, TypeDamage.Pure);

ability.ApplyDamage(unit);