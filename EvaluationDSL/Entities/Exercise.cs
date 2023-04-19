namespace EvaluationDSL.Entities;

public class Exercise
{
    public string Id { get; set; }
    public Score Score { get; set; }

    public Exercise(string id, Score score)
    {
        Id = id;
        Score = score;
    }
}