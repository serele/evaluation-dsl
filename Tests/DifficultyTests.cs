using EvaluationDSL.Entities;

namespace Tests;

public class DifficultyTests
{
    [Fact]
    public void Difficulty_Low_HasCorrectValue()
    {
        // Arrange
        Difficulty difficulty = Difficulty.Low;

        // Assert
        Assert.Equal(0, (int)difficulty);
    }

    [Fact]
    public void Difficulty_Medium_HasCorrectValue()
    {
        // Arrange
        Difficulty difficulty = Difficulty.Medium;

        // Assert
        Assert.Equal(1, (int)difficulty);
    }

    [Fact]
    public void Difficulty_High_HasCorrectValue()
    {
        // Arrange
        Difficulty difficulty = Difficulty.High;

        // Assert
        Assert.Equal(2, (int)difficulty);
    }
}