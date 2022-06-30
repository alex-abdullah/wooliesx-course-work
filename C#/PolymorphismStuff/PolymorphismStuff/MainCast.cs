using System;
namespace PolymorphismStuff
{
    public class MainCast : TekkenCharacter
    {
        public MainCast(string name, string style, int maxHealth) : base(name, style, maxHealth)
        {
            Name = name;
            Style = style;
            MaxHealth = maxHealth;
        }

        public override bool ActivateSpecial()
        {
            if (CurrentHealth < 25)
                return true;
            return false;

        }
    }
}
