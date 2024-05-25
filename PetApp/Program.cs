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
                    typeOfPet = "Dog";
                    break;
            }
            return typeOfPet;
        }

    }
}
