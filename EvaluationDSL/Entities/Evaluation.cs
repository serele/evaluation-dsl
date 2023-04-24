namespace EvaluationDSL.Entities;

public class Evaluation
{
    public Guid Id { get; }
    public Lesson Lesson { get; set; }
    public float Score { get; set; }

    public Evaluation(Lesson lesson)
    {
        Id = Guid.NewGuid();
        Lesson = lesson;
        Score =  CalculateScore();
    }

    private float CalculateScore()
    {
        float sum = Lesson.Exercises.Sum(exercise => (int)exercise.Score);
        return sum / Lesson.Exercises.Count;
    }
}