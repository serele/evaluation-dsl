using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class EvaluationTests
{
    [Fact]
    public void Evaluation_IdIsUnique()
    {
        // Arrange
        List<Activity> activities1 = new List<Activity>()
        {
            new Activity("1.1"),
            new Activity("1.2"),
            new Activity("1.4"),
            new Activity("1.5")
        };
        List<Activity> activities2 = new List<Activity>()
        {
            new Activity("2.1"),
            new Activity("2.2"),
            new Activity("2.4"),
            new Activity("2.5")
        };
        Lesson lesson1 = new Lesson("16. While Loops in Farmer", 9, 18, Type.Loops, Difficulty.Low, activities1);
        Lesson lesson2 = new Lesson("20. Functions with Minecraft", 9, 18, Type.Functions, Difficulty.Medium, activities2);

        // Act
        Evaluation evaluation1 = new Evaluation(lesson1);
        Evaluation evaluation2 = new Evaluation(lesson2);;

        // Assert
        Assert.NotEqual(evaluation1.Id, evaluation2.Id);
    }

    [Fact]
    public void Evaluation_Lesson_IsNotNull()
    {
        // Arrange
        List<Activity> activities = new List<Activity>()
        {
            new Activity("27.1"),
            new Activity("27.2"),
            new Activity("27.3"),
            new Activity("27.4")
        };
        Lesson lesson = new Lesson("27. For Loops with Bee", 9, 18, Type.Loops, Difficulty.Medium, activities);
        Evaluation evaluation = new Evaluation(lesson);

        // Assert
        Assert.NotNull(evaluation.Lesson);
    }

    [Fact]
    public void Evaluation_Score_IsInRange()
    {
        // Arrange
        Activity activity1 = new Activity("29.1");
        Activity activity2 = new Activity("29.2");
        Activity activity3 = new Activity("29.3");
        Activity activity4 = new Activity("29.4");
        
        activity1.Status = Status.CompletedPerfect;
        activity2.Status = Status.CompletedTooManyBlocks;
        activity3.Status = Status.InProgress;
        activity4.Status = Status.CompletedPerfect;
        
        List<Activity> activities = new List<Activity>()
        {
            activity1,
            activity2,
            activity3,
            activity4
        };
        
        Lesson lesson = new Lesson("29. End of Course Project", 9, 18, Type.EndOfCourseProject, Difficulty.High, activities);
        Evaluation evaluation = new Evaluation(lesson);

        // Assert
        Assert.InRange(evaluation.Score, 0, 10);
    }
    
    [Fact]
    public void Evaluation_HasLesson()
    {
        // Arrange
        Activity activity1 = new Activity("2.1");
        Activity activity2 = new Activity("2.2");
        Activity activity3 = new Activity("2.3");
        Activity activity4 = new Activity("2.4");
        
        activity1.Status = Status.InProgress;
        activity2.Status = Status.CompletedTooManyBlocks;
        activity3.Status = Status.CompletedTooManyBlocks;
        activity4.Status = Status.CompletedPerfect;
        
        List<Activity> activities = new List<Activity>()
        {
            activity1,
            activity2,
            activity3,
            activity4
        };
        Lesson lesson = new Lesson("2. Debugging in Maze", 9, 18, Type.Sequencing, Difficulty.Low, activities);
        Evaluation evaluation = new Evaluation(lesson);

        // Assert
        Assert.Equal(lesson, evaluation.Lesson);
    }

    [Fact]
    public void Evaluation_CalculateScore()
    {
        // Arrange
        Activity activity11 = new Activity("1.1");
        Activity activity12 = new Activity("2.2");
        Activity activity13 = new Activity("3.3");
        Activity activity14 = new Activity("4.4");
        
        activity11.Status = Status.InProgress;
        activity12.Status = Status.CompletedTooManyBlocks;
        activity13.Status = Status.CompletedTooManyBlocks;
        activity14.Status = Status.CompletedPerfect;
        
        List<Activity> activities1 = new List<Activity>()
        {
            activity11,
            activity12,
            activity13,
            activity14
        };
        Lesson lesson1 = new Lesson("7. Sprites in Action", 9, 18, Type.Sprites, Difficulty.High, activities1);
        float sum = activities1.Sum(activity => (int)activity.Status);
        float expectedScore1 = sum / activities1.Count(a => a.Status != Status.NotStarted);;
        
        Activity activity21 = new Activity("2.1");
        Activity activity22 = new Activity("2.2");
        Activity activity23 = new Activity("2.3");
        Activity activity24 = new Activity("2.4");
        
        activity21.Status = Status.InProgress;
        activity22.Status = Status.CompletedTooManyBlocks;
        activity23.Status = Status.CompletedTooManyBlocks;
        activity24.Status = Status.CompletedPerfect;
        
        List<Activity> activities2 = new List<Activity>()
        {
            activity21,
            activity22,
            activity23,
            activity24
        };
        Lesson lesson2 = new Lesson("10. Loops", 12, 18, Type.Loops, Difficulty.Medium, activities2);
        sum = activities2.Sum(activity => (int)activity.Status);
        float expectedScore2 = sum / activities2.Count(a => a.Status != Status.NotStarted);
        
        Activity activity31 = new Activity("3.1");
        Activity activity32 = new Activity("3.2");
        Activity activity33 = new Activity("3.3");
        Activity activity34 = new Activity("3.4");
        
        activity31.Status = Status.InProgress;
        activity32.Status = Status.CompletedTooManyBlocks;
        activity33.Status = Status.CompletedTooManyBlocks;
        activity34.Status = Status.CompletedPerfect;
        
        List<Activity> activities3 = new List<Activity>()
        {
            activity31,
            activity32,
            activity33,
            activity34
        };
        Lesson lesson3 = new Lesson("5. Functions", 12, 18, Type.Functions, Difficulty.Low, activities3);
        sum = activities3.Sum(activity => (int)activity.Status);
        float expectedScore3 = sum / activities3.Count(a => a.Status != Status.NotStarted);;
        
        // Act
        Evaluation evaluation1 = new Evaluation(lesson1);
        Evaluation evaluation2 = new Evaluation(lesson2);
        Evaluation evaluation3 = new Evaluation(lesson3);

        // Assert
        Assert.Equal(expectedScore1, evaluation1.Score);
        Assert.Equal(expectedScore2, evaluation2.Score);
        Assert.Equal(expectedScore3, evaluation3.Score);
    }
}