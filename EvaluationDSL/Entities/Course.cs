namespace EvaluationDSL.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Activity> Activities { get; set; }
}