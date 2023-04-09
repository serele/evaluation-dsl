using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class EvaluationTests
{
    [Fact]
    public void Evaluation_IdIsUnique()
    {
        // Arrange
        Activity activity1 = new Activity("16. While Loops in Farmer", 9, 18, Type.Loops, Difficulty.Low);
        Activity activity2 = new Activity("20. Functions with Minecraft", 9, 18, Type.Functions, Difficulty.Medium);

        // Act
        Evaluation evaluation1 = new Evaluation(activity1, 7.5f);
        Evaluation evaluation2 = new Evaluation(activity2, 8.0f);;

        // Assert
        Assert.NotEqual(evaluation1.Id, evaluation2.Id);
    }

    [Fact]
    public void Evaluation_Activity_IsNotNull()
    {
        // Arrange
        Activity activity = new Activity("27. For Loops with Bee", 9, 18, Type.Loops, Difficulty.Medium);
        Evaluation evaluation = new Evaluation(activity, 6.5f);

        // Assert
        Assert.NotNull(evaluation.Activity);
    }

    [Fact]
    public void Evaluation_Score_IsInRange()
    {
        // Arrange
        Activity activity = new Activity("29. End of Course Project", 9, 18, Type.Project, Difficulty.High);
        Evaluation evaluation = new Evaluation(activity, 8.5f);

        // Assert
        Assert.InRange(evaluation.Score, 0, 10);
    }
    
    [Fact]
    public void Evaluation_HasActivity()
    {
        // Arrange
        Activity activity = new Activity("2. Debugging in Maze", 9, 18, Type.Sequences, Difficulty.Low);
        Evaluation evaluation = new Evaluation(activity, 7);

        // Assert
        Assert.Equal(activity, evaluation.Activity);
    }

    [Fact]
    public void Evaluation_HasScore()
    {
        // Arrange
        Activity activity = new Activity("7. Sprites in Action", 9, 18, Type.Sprites, Difficulty.Low);
        float score = 0.5f;
        Evaluation evaluation = new Evaluation(activity, score);

        // Assert
        Assert.Equal(score, evaluation.Score);
    }
}