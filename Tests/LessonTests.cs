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
        List<Activity> activities = new List<Activity>()
        {
            new Activity("0.1"),
            new Activity("0.2"),
            new Activity("0.3")
        };

        // Act
        Lesson lesson = new Lesson(name, ageMin, ageMax, type, difficulty, activities);

        // Assert
        Assert.Equal(name, lesson.Name);
        Assert.Equal(ageMin, lesson.AgeMin);
        Assert.Equal(ageMax, lesson.AgeMax);
        Assert.Equal(type, lesson.Type);
        Assert.Equal(difficulty, lesson.Difficulty);
        Assert.Equal(activities, lesson.Activities);
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
        List<Activity> activities1 = new List<Activity>()
        {
            new Activity("1.1"),
            new Activity("1.2"),
            new Activity("1.3")
        };

        string nameLesson2 = "2. Debugging in Maze";
        int ageMinLesson2 = 9;
        int ageMaxLesson2 = 18;
        Type typeLesson2 = Type.Sequences;
        Difficulty difficultyLesson2 = Difficulty.Medium;
        List<Activity> activities2 = new List<Activity>()
        {
            new Activity("2.1"),
            new Activity("2.2"),
            new Activity("2.3")
        };

        // Act
        Lesson lesson1 = new Lesson(nameLesson1, ageMinLesson1, ageMaxLesson1, typeLesson1, difficultyLesson1, activities1);
        Lesson lesson2 = new Lesson(nameLesson2, ageMinLesson2, ageMaxLesson2, typeLesson2, difficultyLesson2, activities2);

        // Assert
        Assert.NotEqual(lesson1.Id, lesson2.Id);
    }
}