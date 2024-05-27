using System;
namespace PetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!Welcome to the Virtual Pet World!!");
            Console.WriteLine("Select your pet from the list:");
            Console.WriteLine("1.Cat");
            Console.WriteLine("2.Dog");
            Console.WriteLine("3.Rabbit");
            string petType = Console.ReadLine();

            Console.Write("You have chosen a wonderful " + getPetType(petType) + ".Give it a name:");
            string petName = Console.ReadLine();



            Pet pet = new Pet(petType, petName);
            Console.WriteLine($"Welcome, {petName} the {petType}!");


            Console.WriteLine("\nInstructions:");
            Console.WriteLine("1. Feed your pet");
            Console.WriteLine("2. Play with your pet");
            Console.WriteLine("3. Let your pet rest");
            Console.WriteLine("4. Check pet status");
            Console.WriteLine("5. Exit the game.");

            bool running = true;
            while (running)
            {
                Console.WriteLine("What would you like to do? ");
                string action = Console.ReadLine().ToLower();

                switch (int.Parse(action))
                {
                    case 1:
                        pet.Feed();
                        break;
                    case 2:
                        pet.Play();
                        break;
                    case 3:
                        pet.Rest();
                        break;
                    case 4:
                        pet.Status();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid action.Please choose any one option from(1-5).");
                        break;
                }
                pet.TimePasses();
                pet.CheckCriticalStatus();
            }

            Console.WriteLine("Thank you for playing!");

        }

        public static string getPetType(string petType)
        {
            string typeOfPet = "";
            switch(int.Parse(petType))
            {
                case 1:
                    typeOfPet = "Cat";
                    break;
                case 2:
                    typeOfPet = "Dog";
                    break;
                case 3:
                    typeOfPet = "Rabbit";
                    break;
            }
            return typeOfPet;
        }

    }
}
