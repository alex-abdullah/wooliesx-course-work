using System;
namespace collections
{
    public class Animals
    {
        public string Species;
        public string Name;
        public string Sound;

        public Animals(string species, string name, string sound)
        {
            Species = species;
            Name = name;
            Sound = sound;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
