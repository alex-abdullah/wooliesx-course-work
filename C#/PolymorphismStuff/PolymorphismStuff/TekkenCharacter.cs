using System;
namespace PolymorphismStuff
{
    public abstract class TekkenCharacter
    {
        public string Name { get; set; }
        public TekkenCharacter(string name, string style, int maxHealth)
        {
            Name = name;
        }
        public string Style;
        public int MaxHealth;
        public int CurrentHealth;
        public bool PatchRequired;


               

        public virtual void ZeroHealth()
        {
            if(CurrentHealth == 0)
            {
                Console.WriteLine("You Lose.");
            }
        }

        public abstract bool ActivateSpecial();
    }
}
