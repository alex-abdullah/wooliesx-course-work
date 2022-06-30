using System;
namespace PolymorphismStuff
{
    public class Mishima : MainCast
    {
        public bool IsMishima = true;

        public Mishima(string name, string style, int maxHealth) : base(name, style, maxHealth)


        {
            Name = name;
            Style = style;
            MaxHealth = maxHealth;

        }


    }
}
