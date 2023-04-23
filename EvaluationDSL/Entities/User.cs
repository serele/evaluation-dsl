namespace EvaluationDSL.Entities;

public class User
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public List<Course> Courses { get; set; }
    public List<Evaluation> Evaluations { get; set; }

    public User(string name, int age, Gender gender, List<Course> courses, List<Evaluation> evaluations)
    {
        Id = Guid.NewGuid();
        Name = name;
        Age = age;
        Gender = gender;
        Courses = courses;
        Evaluations = evaluations;
    }
}