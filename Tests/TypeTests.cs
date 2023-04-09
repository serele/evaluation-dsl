using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class TypeTests
{
    [Fact]
    public void Type_Sequences_HasCorrectValue()
    {
        // Arrange
        Type type = Type.Sequences;

        // Assert
        Assert.Equal(0, (int)type);
    }

    [Fact]
    public void Type_Sprites_HasCorrectValue()
    {
        // Arrange
        Type type = Type.Sprites;

        // Assert
        Assert.Equal(1, (int)type);
    }

    [Fact]
    public void Type_Events_HasCorrectValue()
    {
        // Arrange
        Type type = Type.Events;

        // Assert
        Assert.Equal(2, (int)type);
    }

    [Fact]
    public void Type_Loops_HasCorrectValue()
    {
        // Arrange
        Type type = Type.Loops;

        // Assert
        Assert.Equal(3, (int)type);
    }

    [Fact]
    public void Type_Conditions_HasCorrectValue()
    {
        // Arrange
        Type type = Type.Conditionals;

        // Assert
        Assert.Equal(4, (int)type);
    }

    [Fact]
    public void Type_Functions_HasCorrectValue()
    {
        // Arrange
        Type type = Type.Functions;

        // Assert
        Assert.Equal(5, (int)type);
    }

    [Fact]
    public void Type_Variables_HasCorrectValue()
    {
        // Arrange
        Type type = Type.Variables;

        // Assert
        Assert.Equal(6, (int)type);
    }
}