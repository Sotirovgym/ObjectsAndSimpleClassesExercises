using System;
using System.Collections.Generic;
using System.Linq;

class Animals
{
    static void Main()
    {
        var dogs = new Dictionary<string, Dog>();
        var cats = new Dictionary<string, Cat>();
        var snakes = new Dictionary<string, Snake>();

        var input = Console.ReadLine();

        while (input != "I'm your Huckleberry")
        {
            var tokens = input.Split(' ');

            var type = tokens[0];

            AddAndSorteAnimals(dogs, cats, snakes, tokens, type);

            PrintAnimalSound(tokens, type, dogs, cats, snakes);

            input = Console.ReadLine();
        }

        foreach (var dog in dogs)
        {
            Console.WriteLine($"Dog: {dog.Value.Name}, Age: {dog.Value.Age}, Number Of Legs: {dog.Value.NumberOfLegs}");
        }

        foreach (var cat in cats)
        {
            Console.WriteLine($"Cat: {cat.Value.Name}, Age: {cat.Value.Age}, IQ: {cat.Value.IntelligenceQuotient}");
        }

        foreach (var snake in snakes)
        {
            Console.WriteLine($"Snake: {snake.Value.Name}, Age: {snake.Value.Age}, Cruelty: {snake.Value.CrueltyCoefficient}");
        }
    }

    private static void AddAndSorteAnimals(Dictionary<string, Dog> dogs, Dictionary<string, Cat> cats, Dictionary<string, Snake> snakes, string[] tokens, string type)
    {
        if (type == "Dog")
        {
            var newDog = new Dog
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                NumberOfLegs = int.Parse(tokens[3])
            };

            dogs.Add(newDog.Name, newDog);

        }
        else if (type == "Cat")
        {
            var newCat = new Cat
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                IntelligenceQuotient = int.Parse(tokens[3])
            };

            cats.Add(newCat.Name, newCat);
        }
        else if (type == "Snake")
        {
            var newSnake = new Snake
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                CrueltyCoefficient = int.Parse(tokens[3])
            };

            snakes.Add(newSnake.Name, newSnake);
        }
    }

    private static void PrintAnimalSound(string[] tokens, string type, Dictionary<string, Dog> dogs, Dictionary<string, Cat> cats, Dictionary<string, Snake> snakes)
    {
        if (type == "talk")
        {
            var name = tokens[1];

            if (dogs.ContainsKey(name))
            {
                dogs[name].ProduceSound();
            }

            if (cats.ContainsKey(name))
            {
                cats[name].ProduceSound();
            }

            if (snakes.ContainsKey(name))
            {
                snakes[name].ProduceSound();
            }
        }
    }
}

