namespace EvaluationDSL.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Evaluation Evaluation { get; set; }
}