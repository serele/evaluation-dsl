namespace EvaluationDSL.Entities;

public class User
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public List<Course> Courses { get; set; }
    public List<Evaluation> Evaluations { get; set; }

    public User(string name, List<Course> courses, List<Evaluation> evaluations)
    {
        Id = Guid.NewGuid();
        Name = name;
        Courses = courses;
        Evaluations = evaluations;
    }
}