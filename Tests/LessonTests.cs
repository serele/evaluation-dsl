using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class LessonTests
{
    [Fact]
    public void Lesson_Constructor_SetsProperties()
    {
        // Arrange
        string name = "Test Lesson";
        int ageMin = 10;
        int ageMax = 20;
        Type type = Type.Loops;
        Difficulty difficulty = Difficulty.Low;
        List<Exercise> exercises = new List<Exercise>()
        {
            new Exercise("0.1"),
            new Exercise("0.2"),
            new Exercise("0.3")
        };

        // Act
        Lesson lesson = new Lesson(name, ageMin, ageMax, type, difficulty, exercises);

        // Assert
        Assert.Equal(name, lesson.Name);
        Assert.Equal(ageMin, lesson.AgeMin);
        Assert.Equal(ageMax, lesson.AgeMax);
        Assert.Equal(type, lesson.Type);
        Assert.Equal(difficulty, lesson.Difficulty);
        Assert.Equal(exercises, lesson.Exercises);
    }

    [Fact]
    public void Lesson_Constructor_SetsUniqueId()
    {
        // Arrange
        string nameLesson1 = "1. Programming with Angry Birds";
        int ageMinLesson1 = 9;
        int ageMaxLesson1 = 18;
        Type typeLesson1 = Type.Sequences;
        Difficulty difficultyLesson1 = Difficulty.Low;
        List<Exercise> exercises1 = new List<Exercise>()
        {
            new Exercise("1.1"),
            new Exercise("1.2"),
            new Exercise("1.3")
        };

        string nameLesson2 = "2. Debugging in Maze";
        int ageMinLesson2 = 9;
        int ageMaxLesson2 = 18;
        Type typeLesson2 = Type.Sequences;
        Difficulty difficultyLesson2 = Difficulty.Medium;
        List<Exercise> exercises2 = new List<Exercise>()
        {
            new Exercise("2.1"),
            new Exercise("2.2"),
            new Exercise("2.3")
        };

        // Act
        Lesson lesson1 = new Lesson(nameLesson1, ageMinLesson1, ageMaxLesson1, typeLesson1, difficultyLesson1, exercises1);
        Lesson lesson2 = new Lesson(nameLesson2, ageMinLesson2, ageMaxLesson2, typeLesson2, difficultyLesson2, exercises2);

        // Assert
        Assert.NotEqual(lesson1.Id, lesson2.Id);
    }
}