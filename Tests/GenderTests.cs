using EvaluationDSL.Entities;

namespace Tests;

public class GenderTests
{
    [Fact]
    public void Gender_Male_HasCorrectValue()
    {
        // Arrange
        Gender gender = Gender.Male;

        // Assert
        Assert.Equal(0, (int)gender);
    }

    [Fact]
    public void Gender_Female_HasCorrectValue()
    {
        // Arrange
        Gender gender = Gender.Female;

        // Assert
        Assert.Equal(1, (int)gender);
    }
}