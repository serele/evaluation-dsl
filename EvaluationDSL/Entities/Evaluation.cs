namespace EvaluationDSL.Entities;

public class Evaluation
{
    public Guid Id { get; }
    public Activity Activity { get; set; }
    public float Score { get; set; }

    public Evaluation(Activity activity)
    {
        Id = Guid.NewGuid();
        Activity = activity;
        Score =  CalculateScore();
    }

    private float CalculateScore()
    {
        float sum = Activity.Exercises.Sum(exercise => (int)exercise.Score);
        return sum / Activity.Exercises.Count;
    }
}