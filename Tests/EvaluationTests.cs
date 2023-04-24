using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class EvaluationTests
{
    [Fact]
    public void Evaluation_IdIsUnique()
    {
        // Arrange
        List<Exercise> exercises1 = new List<Exercise>()
        {
            new Exercise("1.1"),
            new Exercise("1.2"),
            new Exercise("1.4"),
            new Exercise("1.5")
        };
        List<Exercise> exercises2 = new List<Exercise>()
        {
            new Exercise("2.1"),
            new Exercise("2.2"),
            new Exercise("2.4"),
            new Exercise("2.5")
        };
        Lesson lesson1 = new Lesson("16. While Loops in Farmer", 9, 18, Type.Loops, Difficulty.Low, exercises1);
        Lesson lesson2 = new Lesson("20. Functions with Minecraft", 9, 18, Type.Functions, Difficulty.Medium, exercises2);

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
        List<Exercise> exercises = new List<Exercise>()
        {
            new Exercise("27.1"),
            new Exercise("27.2"),
            new Exercise("27.3"),
            new Exercise("27.4")
        };
        Lesson lesson = new Lesson("27. For Loops with Bee", 9, 18, Type.Loops, Difficulty.Medium, exercises);
        Evaluation evaluation = new Evaluation(lesson);

        // Assert
        Assert.NotNull(evaluation.Lesson);
    }

    [Fact]
    public void Evaluation_Score_IsInRange()
    {
        // Arrange
        Exercise exercise1 = new Exercise("29.1");
        Exercise exercise2 = new Exercise("29.2");
        Exercise exercise3 = new Exercise("29.3");
        Exercise exercise4 = new Exercise("29.4");
        
        exercise1.Score = Score.CompletedPerfect;
        exercise2.Score = Score.CompletedTooManyBlocks;
        exercise3.Score = Score.InProgress;
        exercise4.Score = Score.CompletedPerfect;
        
        List<Exercise> exercises = new List<Exercise>()
        {
            exercise1,
            exercise2,
            exercise3,
            exercise4
        };
        
        Lesson lesson = new Lesson("29. End of Course Project", 9, 18, Type.Project, Difficulty.High, exercises);
        Evaluation evaluation = new Evaluation(lesson);

        // Assert
        Assert.InRange(evaluation.Score, 0, 10);
    }
    
    [Fact]
    public void Evaluation_HasLesson()
    {
        // Arrange
        Exercise exercise1 = new Exercise("2.1");
        Exercise exercise2 = new Exercise("2.2");
        Exercise exercise3 = new Exercise("2.3");
        Exercise exercise4 = new Exercise("2.4");
        
        exercise1.Score = Score.InProgress;
        exercise2.Score = Score.CompletedTooManyBlocks;
        exercise3.Score = Score.CompletedTooManyBlocks;
        exercise4.Score = Score.CompletedPerfect;
        
        List<Exercise> exercises = new List<Exercise>()
        {
            exercise1,
            exercise2,
            exercise3,
            exercise4
        };
        Lesson lesson = new Lesson("2. Debugging in Maze", 9, 18, Type.Sequences, Difficulty.Low, exercises);
        Evaluation evaluation = new Evaluation(lesson);

        // Assert
        Assert.Equal(lesson, evaluation.Lesson);
    }

    [Fact]
    public void Evaluation_CalculateScore()
    {
        // Arrange
        Exercise exercise11 = new Exercise("1.1");
        Exercise exercise12 = new Exercise("2.2");
        Exercise exercise13 = new Exercise("3.3");
        Exercise exercise14 = new Exercise("4.4");
        
        exercise11.Score = Score.InProgress;
        exercise12.Score = Score.CompletedTooManyBlocks;
        exercise13.Score = Score.CompletedTooManyBlocks;
        exercise14.Score = Score.CompletedPerfect;
        
        List<Exercise> exercises1 = new List<Exercise>()
        {
            exercise11,
            exercise12,
            exercise13,
            exercise14
        };
        Lesson lesson1 = new Lesson("7. Sprites in Action", 9, 18, Type.Sprites, Difficulty.High, exercises1);
        float sum = exercises1.Sum(exercise => (int)exercise.Score);
        float expectedScore1 = sum / exercises1.Count;
        
        Exercise exercise21 = new Exercise("2.1");
        Exercise exercise22 = new Exercise("2.2");
        Exercise exercise23 = new Exercise("2.3");
        Exercise exercise24 = new Exercise("2.4");
        
        exercise21.Score = Score.InProgress;
        exercise22.Score = Score.CompletedTooManyBlocks;
        exercise23.Score = Score.CompletedTooManyBlocks;
        exercise24.Score = Score.CompletedPerfect;
        
        List<Exercise> exercises2 = new List<Exercise>()
        {
            exercise21,
            exercise22,
            exercise23,
            exercise24
        };
        Lesson lesson2 = new Lesson("10. Loops", 12, 18, Type.Loops, Difficulty.Medium, exercises2);
        sum = exercises2.Sum(exercise => (int)exercise.Score);
        float expectedScore2 = sum / exercises2.Count;
        
        Exercise exercise31 = new Exercise("3.1");
        Exercise exercise32 = new Exercise("3.2");
        Exercise exercise33 = new Exercise("3.3");
        Exercise exercise34 = new Exercise("3.4");
        
        exercise31.Score = Score.InProgress;
        exercise32.Score = Score.CompletedTooManyBlocks;
        exercise33.Score = Score.CompletedTooManyBlocks;
        exercise34.Score = Score.CompletedPerfect;
        
        List<Exercise> exercises3 = new List<Exercise>()
        {
            exercise31,
            exercise32,
            exercise33,
            exercise34
        };
        Lesson lesson3 = new Lesson("5. Functions", 12, 18, Type.Functions, Difficulty.Low, exercises3);
        sum = exercises3.Sum(exercise => (int)exercise.Score);
        float expectedScore3 = sum / exercises3.Count;
        
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