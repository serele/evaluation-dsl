namespace EvaluationDSL.Entities;

public class Evaluation
{
    public Guid Id { get; }
    public Activity Activity { get; set; }
    public float Score { get; set; }

    public Evaluation(Activity activity, float score)
    {
        Id = Guid.NewGuid();
        Activity = activity;
        Score = score;
    }
}