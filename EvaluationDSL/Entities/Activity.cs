namespace EvaluationDSL.Entities;

public class Activity
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int AgeMin { get; set; }
    public int AgeMax { get; set; }
    public Type Type { get; set; }
    public Difficulty Difficulty { get; set; }

    public Activity()
    {
        
    }
    
    public Activity(string name, int ageMin, int ageMax, Type type, Difficulty difficulty)
    {
        Id = Guid.NewGuid();
        Name = name;
        AgeMin = ageMin;
        AgeMax = ageMax;
        Type = type;
        Difficulty = difficulty;
    }
}