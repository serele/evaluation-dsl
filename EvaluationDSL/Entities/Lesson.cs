namespace EvaluationDSL.Entities;

public class Lesson
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int AgeMin { get; set; }
    public int AgeMax { get; set; }
    public Type Type { get; set; }
    public Difficulty Difficulty { get; set; }
    public List<Activity> Activities { get; set; }

    public Lesson(string name, int ageMin, int ageMax, Type type, Difficulty difficulty, List<Activity> activities)
    {
        Id = Guid.NewGuid();
        Name = name;
        AgeMin = ageMin;
        AgeMax = ageMax;
        Type = type;
        Difficulty = difficulty;
        Activities = activities;
    }
}