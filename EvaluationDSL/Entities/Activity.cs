namespace EvaluationDSL.Entities;

public class Activity
{
    public string Id { get; set; }
    public Score Score { get; set; }

    public Activity(string id)
    {
        Id = id;
        Score = Score.InProgress;
    }
}