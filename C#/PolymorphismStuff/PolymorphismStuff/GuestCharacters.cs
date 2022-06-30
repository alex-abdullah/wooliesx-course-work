using System;
namespace PolymorphismStuff
{
    public class GuestCharacters : TekkenCharacter
    {
        public GuestCharacters(string name, string style, int maxHealth)
        {
            Name = name;
            Style = style;
            MaxHealth = maxHealth;
        }

        public override bool ActivateSpecial()
        {
            if (CurrentHealth < 75)
                return true;
            return false;


        }
    }
}
