namespace PetApp
{
    internal class Pet
    {
        public string Type { get; set; }
        public string Name { get; set; }
        private int hunger;
        private int happiness;
        private int health;

        public Pet(string type, string name)
        {
            Type=type;
            Name=name;
            hunger=5;
            happiness=5;
            health=5;
        }

        public void Feed()
        {
            if (hunger > 1)
            {
                hunger -= 2;
                health += 1;
                Console.WriteLine($"{Name} is fed.Hunger decreases and health increases slightly.");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }

        public void Play()
        {
            if (hunger < 9)
            {
                happiness += 2;
                hunger += 1;
                Console.WriteLine($"{Name} plays happily. Happiness increases and hunger increases slightly.");
            }
            else
            {
                Console.WriteLine($"{Name} is too hungry to play.");
            }
        }

        public void Rest()
        {
            if (happiness > 1)
            {
                health += 2;
                happiness -= 1;
                Console.WriteLine($"{Name} rests. Health improves and happiness decreases slightly.");
            }
            else
            {
                Console.WriteLine($"{Name} is too unhappy to rest.");
            }
        }

        public void Status()
        {
            Console.WriteLine($"\n{Name}'s Status:");
            Console.WriteLine($"Hunger: {hunger}/10");
            Console.WriteLine($"Happiness: {happiness}/10");
            Console.WriteLine($"Health: {health}/10");
        }

        public void TimePasses()
        {
            hunger += 1;
            happiness -= 1;

            if (hunger > 10)
            {
                hunger = 10;
            }else if(hunger < 0)
            {
                hunger = 0;
            }
            if (happiness > 10)
            {
                happiness = 10;
            }
            else if (happiness < 0)
            {
                happiness = 0;
            }
            if (health > 10)
            {
                health = 10;
            }
            else if (health < 0)
            {
                health = 0;
            }
        }

        public void CheckCriticalStatus()
        {
            if (hunger >= 9)
            {
                Console.WriteLine($"{Name} is very hungry!!!");
            }
            if (happiness <= 5)
            {
                Console.WriteLine($"{Name} is very unhappy!!!");
            }
            if (health <= 2)
            {
                Console.WriteLine($"{Name} is in poor health!!!");
            }
            if (hunger >= 10 || happiness <= 0)
            {
                health -= 1;
            }
        }
    }
}