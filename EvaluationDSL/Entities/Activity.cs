namespace EvaluationDSL.Entities;

public class Activity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int AgeMin { get; set; }
    public int AgeMax { get; set; }
    public Type Type { get; set; }
    public Difficulty Difficulty { get; set; }

    public Activity(string name, int ageMin, int ageMax, Type type, Difficulty difficulty)
    {
        Id = Guid.NewGuid().ToString("N");
        Name = name;
        AgeMin = ageMin;
        AgeMax = ageMax;
        Type = type;
        Difficulty = difficulty;
    }
}