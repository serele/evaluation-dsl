namespace EvaluationDSL.Entities;

public class Lesson
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int AgeMin { get; set; }
    public int AgeMax { get; set; }
    public Type Type { get; set; }
    public Difficulty Difficulty { get; set; }
    public List<Exercise> Exercises { get; set; }

    public Lesson(string name, int ageMin, int ageMax, Type type, Difficulty difficulty, List<Exercise> exercises)
    {
        Id = Guid.NewGuid();
        Name = name;
        AgeMin = ageMin;
        AgeMax = ageMax;
        Type = type;
        Difficulty = difficulty;
        Exercises = exercises;
    }
}