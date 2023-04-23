using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class CourseTests
{
    [Fact]
    public void Course_Constructor_SetsProperties()
    {
        // Arrange
        string name = "Express Course (2022)";
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
        
        List<Activity> activities = new List<Activity>()
        {
            new Activity("1. Programming with Angry Birds", 9, 18, Type.Sequences, Difficulty.Low, exercises1),
            new Activity("2. Debugging in Maze", 9, 18, Type.Sequences, Difficulty.Low, exercises2),
            new Activity("3. Collecting Treasure with Laurel", 9, 18, Type.Sequences, Difficulty.Low, exercises3),
            new Activity("4. Creating Art with Code", 9, 18, Type.Sequences, Difficulty.Low, exercises4),
            
            new Activity("5. Swimming Fish in Sprite Lab", 9, 18, Type.Sprites, Difficulty.Low, exercises5),
            new Activity("6. Making Sprites", 9, 18, Type.Sprites, Difficulty.Low, exercises6),
            
            new Activity("7. Sprites in Action", 9, 18, Type.Events, Difficulty.Low, exercises1),
            new Activity("8. Virtual Pet with Sprite Lab", 9, 18, Type.Events, Difficulty.Low, exercises2),
            new Activity("9. Dance Party", 9, 18, Type.Events, Difficulty.Low, exercises3),
            
            new Activity("10. Loops with Rey and BB-8", 9, 18, Type.Loops, Difficulty.Low, exercises4),
            new Activity("11. Mini-Project: Sticker Art", 9, 18, Type.Loops, Difficulty.Low, exercises5),
            new Activity("12. Nested Loops in Maze", 9, 18, Type.Loops, Difficulty.Low, exercises6),
            new Activity("13. Snowflakes with Anna and Elsa", 9, 18, Type.Loops, Difficulty.Low, exercises1),
            
            new Activity("14. Looking ahead with Minecraft", 9, 18, Type.Conditionals, Difficulty.Low, exercises1),
            new Activity("15. If/else with Bee", 9, 18, Type.Conditionals, Difficulty.Low, exercises2),
            new Activity("16. While Loops in Farmer", 9, 18, Type.Conditionals, Difficulty.Low, exercises3),
            new Activity("17. Conditionals in Minecraft: Voyage Aquatic", 9, 18, Type.Conditionals, Difficulty.Low, exercises4),
            new Activity("18. Until Loops in Maze", 9, 18, Type.Conditionals, Difficulty.Low, exercises5),
            new Activity("19. Harvesting with Conditionals", 9, 18, Type.Conditionals, Difficulty.Low, exercises6),
            
            new Activity("20. Functions in Minecraft", 9, 18, Type.Functions, Difficulty.Low, exercises1),
            new Activity("21. Functions with Harvester", 9, 18, Type.Functions, Difficulty.Low, exercises2),
            new Activity("22. Functions with Artist", 9, 18, Type.Functions, Difficulty.Low, exercises3),
            
            new Activity("23. Text and Prompts", 9, 18, Type.Variables, Difficulty.Low, exercises1),
            new Activity("24. Counting with Variables", 9, 18, Type.Variables, Difficulty.Low, exercises2),
            new Activity("25. Using Variables with the Artist", 9, 18, Type.Variables, Difficulty.Low, exercises3),
            new Activity("26. Variables with the Bee", 9, 18, Type.Variables, Difficulty.Low, exercises4),
            
            new Activity("27. For Loops with Bee", 9, 18, Type.Loops, Difficulty.Low, exercises1),
            new Activity("28. For Loops with Artist", 9, 18, Type.Loops, Difficulty.Low, exercises2),
            
            new Activity("29. End of Course Project", 9, 18, Type.Project, Difficulty.Medium, exercises1),
        };
        
        // Act
        Course course = new Course(name, activities);
        
        // Assert
        Assert.Equal(name, course.Name);
        Assert.Equal(activities, course.Activities);
    }

    [Fact]
    public void Course_IdIsUnique()
    {
        // Arrange
        string courseName1 = "Express Course";
        string courseName2 = "Advanced Course";
        
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
            new Exercise("2.4")
        };
        List<Exercise> exercises3 = new List<Exercise>()
        {
            new Exercise("10.1"),
            new Exercise("10.2"),
            new Exercise("10.4")
        };
        List<Exercise> exercises4 = new List<Exercise>()
        {
            new Exercise("11.1"),
            new Exercise("11.2"),
            new Exercise("11.4")
        };

        Activity activity1 = new Activity("1. Programming with Angry Birds", 9, 18, Type.Events, Difficulty.Low, exercises1);
        Activity activity2 = new Activity("2. Debugging in Maze", 9, 18, Type.Sequences, Difficulty.Low, exercises2);
        List<Activity> activities1 = new List<Activity>();
        activities1.Add(activity1);
        activities1.Add(activity2);
        
        Activity activity3 = new Activity("1. Operators", 9, 18, Type.Events, Difficulty.Low, exercises3);
        Activity activity4 = new Activity("2. Linked lists", 9, 18, Type.Sequences, Difficulty.Low, exercises4);
        List<Activity> activities2 = new List<Activity>();
        activities1.Add(activity3);
        activities1.Add(activity4);

        // Act
        Course course1 = new Course(courseName1, activities1);
        Course course2 = new Course(courseName2, activities2);

        // Assert
        Assert.NotEqual(course1.Id, course2.Id);

    }
}