namespace EvaluationDSL.Entities;

public class Course
{
    public Guid Id { get; }
    public string Name { get; set; }
    public List<Activity> Activities { get; set; }

    public Course(string name, List<Activity> activities)
    {
        Id = Guid.NewGuid();
        Name = name;
        Activities = activities;
    }
}