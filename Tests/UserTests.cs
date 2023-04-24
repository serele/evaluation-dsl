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
        
        List<Activity> activities1 = new List<Activity>()
        {
            new Activity("1.1"),
            new Activity("1.2"),
            new Activity("1.3")
        };
        List<Activity> activities2 = new List<Activity>()
        {
            new Activity("2.1"),
            new Activity("2.2"),
            new Activity("2.3")
        };
        List<Activity> activities3 = new List<Activity>()
        {
            new Activity("3.1"),
            new Activity("3.2"),
            new Activity("3.3")
        };
        List<Activity> activities4 = new List<Activity>()
        {
            new Activity("4.1"),
            new Activity("4.2"),
            new Activity("4.3")
        };
        List<Activity> activities5 = new List<Activity>()
        {
            new Activity("5.1"),
            new Activity("5.2"),
            new Activity("5.3")
        };
        List<Activity> activities6 = new List<Activity>()
        {
            new Activity("6.1"),
            new Activity("6.2"),
            new Activity("6.3")
        };
        List<Lesson> lesson1 = new List<Lesson>()
        {
            new Lesson("1. Programming with Angry Birds", 9, 18, Type.Sequences, Difficulty.Low, activities1),
            new Lesson("2. Debugging in Maze", 9, 18, Type.Functions, Difficulty.Medium, activities2),
            new Lesson("3. Collecting Treasure with Laurel", 9, 18, Type.Loops, Difficulty.High, activities3),
        };
        
        List<Lesson> lessons2 = new List<Lesson>()
        {
            new Lesson("4. Loops with Angry Birds", 9, 18, Type.Loops, Difficulty.Medium, activities4),
            new Lesson("5. Variables and constants", 9, 18, Type.Variables, Difficulty.Medium, activities5),
            new Lesson("6. Functions with Bee", 9, 18, Type.Functions, Difficulty.High, activities6),
        };
        
        List<Course> courses1 = new List<Course>
        {
            new Course("Express Course (2022)", lesson1)
        };
        List<Course> courses2 = new List<Course>
        {
            new Course("Advance Course (2022)", lessons2)
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