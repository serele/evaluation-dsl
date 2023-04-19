using EvaluationDSL.Entities;

namespace Tests;

public class ExerciseTests
{
    [Fact]
    public void Exercise_Constructor_SetsProperties()
    {
        // Arrange
        string id = "8.2";
        Score score = Score.CompletedPerfect;
        Exercise exercise = new Exercise(id, score);
        
        // Assert
        Assert.Equal(id, exercise.Id);
        Assert.Equal(score, exercise.Score);
    }
    
    [Fact]
    public void Exercise_IdIsUnique()
    {
        // Arrange
        Exercise exercise1 = new Exercise("1.1", Score.CompletedPerfect);
        Exercise exercise2 = new Exercise("8.4", Score.InProgress);

        // Assert
        Assert.NotEqual(exercise1.Id, exercise2.Id);
    }
}