using System;
namespace classes
{
    internal class AdoptionCenter
    {
        // Adds a pet to an owner and an owner to a pet
        static public void Adopt(Person person, Animal animal)
        {
            // A reference to the class that this method is running on

            if (person.Pet != null || animal.Owner != null)
            { 
                Console.WriteLine( $"Sorry, {person.Name} already owns a pet.");
                return;
            }
            person.Pet = animal;
            animal.Owner = person;

        }

        // Removes a pet from an owner and an owner from a pet
        static public void UnAdopt(Person person, Animal animal)
        {
            if (person.Pet == null || animal.Owner == null)
            {
                Console.WriteLine($"{person.Name} does not own a pet");
                return;
            }

            person.Pet = null;
            animal.Owner = null;
        }


    }
}
