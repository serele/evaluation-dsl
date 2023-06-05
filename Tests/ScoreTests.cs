using EvaluationDSL.Entities;

namespace Tests;

public class ScoreTests
{
    [Fact]
    public void Score_InProgress_HasCorrectValue()
    {
        // Arrange
        Status status = Status.InProgress;

        // Assert
        Assert.Equal(0, (int)status);
    }

    [Fact]
    public void Score_CompletedTooManyBlocks_HasCorrectValue()
    {
        // Arrange
        Status status = Status.CompletedTooManyBlocks;

        // Assert
        Assert.Equal(5, (int)status);
    }

    [Fact]
    public void Score_CompletedPerfect_HasCorrectValue()
    {
        // Arrange
        Status status = Status.CompletedPerfect;

        // Assert
        Assert.Equal(10, (int)status);
    }
}