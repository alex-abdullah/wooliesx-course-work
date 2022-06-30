using System;
namespace InterfaceDemo
{
    public class Potion<T> where T : IEffect
    {
        private T _effect;

        private double _strength;
        public void Use(ITarget target)
        {
            _effect.DoEffect(target, _strength);
        }

        public Potion(T effect, double strength)
        {
            _effect = effect;
            _strength = strength;
        }
    }
}
