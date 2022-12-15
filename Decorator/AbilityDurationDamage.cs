namespace Decorator
{
    internal class AbilityDurationDamage : AbilityUpgrade
    {
        private float _duration;
        private float _frequency;
        public AbilityDurationDamage(IAbility mainAbility, float duration, float frequency) : base(mainAbility)
        {
            _duration = duration;
            _frequency = frequency;
        }

        public async override void ApplyDamage(IDamageable canBeDamage)
        {
            await ApplyDamageAsync(canBeDamage);

        }

        private async Task ApplyDamageAsync(IDamageable canBeDamage)
        {
            
            for(float i = 0; i < _duration; i += _frequency)
            {
                base.ApplyDamage(canBeDamage);
                await Task.Delay((int)(_frequency * 1000));
            }
        }

    }
}
