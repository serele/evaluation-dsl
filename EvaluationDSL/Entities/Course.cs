namespace EvaluationDSL.Entities;

public class Course
{
    public Guid Id { get; }
    public string Name { get; set; }
    public List<Lesson> Lessons { get; set; }

    public Course(string name, List<Lesson> lessons)
    {
        Id = Guid.NewGuid();
        Name = name;
        Lessons = lessons;
    }
}