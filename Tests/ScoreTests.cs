using EvaluationDSL.Entities;

namespace Tests;

public class ScoreTests
{
    [Fact]
    public void Score_InProgress_HasCorrectValue()
    {
        // Arrange
        Score score = Score.InProgress;

        // Assert
        Assert.Equal(0, (int)score);
    }

    [Fact]
    public void Score_CompletedTooManyBlocks_HasCorrectValue()
    {
        // Arrange
        Score score = Score.CompletedTooManyBlocks;

        // Assert
        Assert.Equal(5, (int)score);
    }

    [Fact]
    public void Score_CompletedPerfect_HasCorrectValue()
    {
        // Arrange
        Score score = Score.CompletedPerfect;

        // Assert
        Assert.Equal(10, (int)score);
    }
}