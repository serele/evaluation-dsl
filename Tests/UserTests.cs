using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class UserTests
{
    [Fact]
    public void User_Constructor_SetsProperties()
    {
        // Arrange
        string expectedName1 = "Mary Hendrix";
        int expectecAge1 = 14;
        Gender expectedGender1 = Gender.Female;

        string expectedName2 = "Uma Roberts";
        int expectecAge2 = 11;
        Gender expectedGender2 = Gender.Female;
        
        List<Exercise> exercises1 = new List<Exercise>()
        {
            new Exercise("1.1"),
            new Exercise("1.2"),
            new Exercise("1.3")
        };
        List<Exercise> exercises2 = new List<Exercise>()
        {
            new Exercise("2.1"),
            new Exercise("2.2"),
            new Exercise("2.3")
        };
        List<Exercise> exercises3 = new List<Exercise>()
        {
            new Exercise("3.1"),
            new Exercise("3.2"),
            new Exercise("3.3")
        };
        List<Exercise> exercises4 = new List<Exercise>()
        {
            new Exercise("4.1"),
            new Exercise("4.2"),
            new Exercise("4.3")
        };
        List<Exercise> exercises5 = new List<Exercise>()
        {
            new Exercise("5.1"),
            new Exercise("5.2"),
            new Exercise("5.3")
        };
        List<Exercise> exercises6 = new List<Exercise>()
        {
            new Exercise("6.1"),
            new Exercise("6.2"),
            new Exercise("6.3")
        };
        List<Lesson> activities1 = new List<Lesson>()
        {
            new Lesson("1. Programming with Angry Birds", 9, 18, Type.Sequences, Difficulty.Low, exercises1),
            new Lesson("2. Debugging in Maze", 9, 18, Type.Functions, Difficulty.Medium, exercises2),
            new Lesson("3. Collecting Treasure with Laurel", 9, 18, Type.Loops, Difficulty.High, exercises3),
        };
        
        List<Lesson> activities2 = new List<Lesson>()
        {
            new Lesson("4. Loops with Angry Birds", 9, 18, Type.Loops, Difficulty.Medium, exercises4),
            new Lesson("5. Variables and constants", 9, 18, Type.Variables, Difficulty.Medium, exercises5),
            new Lesson("6. Functions with Bee", 9, 18, Type.Functions, Difficulty.High, exercises6),
        };
        
        List<Course> courses1 = new List<Course>
        {
            new Course("Express Course (2022)", activities1)
        };
        List<Course> courses2 = new List<Course>
        {
            new Course("Advance Course (2022)", activities2)
        };

        List<Evaluation> expectedEvaluations1 = new List<Evaluation>();
        List<Evaluation> expectedEvaluations2 = new List<Evaluation>();

        // Act
        User user1 = new User(expectedName1, expectecAge1, expectedGender1, courses1, expectedEvaluations1);
        User user2 = new User(expectedName2, expectecAge2, expectedGender2, courses2, expectedEvaluations2);

        // Assert
        Assert.Equal(expectedName1, user1.Name);
        Assert.Equal(expectecAge1, user1.Age);
        Assert.Equal(expectedGender1, user1.Gender);
        Assert.Equal(courses1, user1.Courses);
        Assert.Equal(expectedEvaluations1, user1.Evaluations);
        
        Assert.Equal(expectedName2, user2.Name);
        Assert.Equal(expectecAge2, user2.Age);
        Assert.Equal(expectedGender2, user2.Gender);
        Assert.Equal(courses2, user2.Courses);
        Assert.Equal(expectedEvaluations2, user2.Evaluations);
    }
    
    [Fact]
    public void User_IdIsUnique()
    {
        // Arrange
        User user1 = new User("George Williams", 11, Gender.Male,new List<Course>(), new List<Evaluation>());
        User user2 = new User("Agatha Wilkins", 12, Gender.Female, new List<Course>(), new List<Evaluation>());

        // Assert
        Assert.NotEqual(user1.Id, user2.Id);
    }
}