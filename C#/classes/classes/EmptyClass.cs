using System;
namespace classes
{
    public class Animal
    {
        public string Species;
        private string Sound;
        public Person Owner;

        public Animal (string species, string sound)
        {
            Species = species;
            Sound = sound;

        }
        public void AnimalSounds()
        {
            Console.WriteLine("The {0} goes {1}.", Species, Sound);
        }

        

        public override string ToString()
        {
            if (Owner == null)
                return $"{Species}, {Sound}";
            return $"The {Species} belongs to {Owner}";
        }
    }
}
