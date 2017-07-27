using System;
using System.Collections.Generic;
using System.Linq;

class Exercises
{
    static void Main()
    {
        var exercises = new List<Exercise>();

        var input = Console.ReadLine();

        while (input != "go go go")
        {
            var tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var newExercise = new Exercise
            {
                Topic = tokens[0],
                CourseName = tokens[1],
                JudgeContestLink = tokens[2],
                Problems = tokens.Skip(3).ToList()
            };

            exercises.Add(newExercise);

            input = Console.ReadLine();
        }

        foreach (var exercise in exercises)
        {
            Console.WriteLine($"Exercises: {exercise.Topic}");
            Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

            var count = 0;
            foreach (var problem in exercise.Problems)
            {
                count++;
                Console.WriteLine($"{count}. {problem}");
            }
        }
    }
}
class Exercise
{
    public string Topic { get; set; }

    public string CourseName { get; set; }

    public string JudgeContestLink { get; set; }

    public List<string> Problems { get; set; }
}

