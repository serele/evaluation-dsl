using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class ActivityTests
{
    [Fact]
    public void Activity_Constructor_SetsProperties()
    {
        // Arrange
        string name = "Test Activity";
        int ageMin = 10;
        int ageMax = 20;
        Type type = Type.Loops;
        Difficulty difficulty = Difficulty.Low;

        // Act
        Activity activity = new Activity(name, ageMin, ageMax, type, difficulty);

        // Assert
        Assert.Equal(name, activity.Name);
        Assert.Equal(ageMin, activity.AgeMin);
        Assert.Equal(ageMax, activity.AgeMax);
        Assert.Equal(type, activity.Type);
        Assert.Equal(difficulty, activity.Difficulty);
    }

    [Fact]
    public void Activity_Constructor_SetsUniqueId()
    {
        // Arrange
        string nameActivity1 = "1. Programming with Angry Birds";
        int ageMinActivity1 = 9;
        int ageMaxActivity1 = 18;
        Type typeActivity1 = Type.Sequences;
        Difficulty difficultyActivity1 = Difficulty.Low;
        
        string nameActivity2 = "2. Debugging in Maze";
        int ageMinActivity2 = 9;
        int ageMaxActivity2 = 18;
        Type typeActivity2 = Type.Sequences;
        Difficulty difficultyActivity2 = Difficulty.Low;

        // Act
        Activity activity1 = new Activity(nameActivity1, ageMinActivity1, ageMaxActivity1, typeActivity1, difficultyActivity1);
        Activity activity2 = new Activity(nameActivity2, ageMinActivity2, ageMaxActivity2, typeActivity2, difficultyActivity2);

        // Assert
        Assert.NotEqual(activity1.Id, activity2.Id);
    }
}