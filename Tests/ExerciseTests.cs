using EvaluationDSL.Entities;

namespace Tests;

public class ExerciseTests
{
    [Fact]
    public void Exercise_Constructor_SetsProperties()
    {
        // Arrange
        string id = "8.2";
        Exercise exercise = new Exercise(id);
        
        // Assert
        Assert.Equal(id, exercise.Id);
    }
    
    [Fact]
    public void Exercise_IdIsUnique()
    {
        // Arrange
        Exercise exercise1 = new Exercise("1.1");
        Exercise exercise2 = new Exercise("8.4");

        // Assert
        Assert.NotEqual(exercise1.Id, exercise2.Id);
    }
}