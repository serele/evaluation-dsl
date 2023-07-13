namespace EvaluationDSL.Entities;

public class Activity
{
    public string Id { get; set; }
    public Status Status { get; set; }

    public Activity(string id)
    {
        Id = id;
        Status = Status.NotStarted;
    }
}