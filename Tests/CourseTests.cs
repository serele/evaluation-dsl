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
        List<Activity> activities = new List<Activity>()
        {
            new Activity("1. Programming with Angry Birds", 9, 18, Type.Sequences, Difficulty.Low),
            new Activity("2. Debugging in Maze", 9, 18, Type.Sequences, Difficulty.Low),
            new Activity("3. Collecting Treasure with Laurel", 9, 18, Type.Sequences, Difficulty.Low),
            new Activity("4. Creating Art with Code", 9, 18, Type.Sequences, Difficulty.Low),
            
            new Activity("5. Swimming Fish in Sprite Lab", 9, 18, Type.Sprites, Difficulty.Low),
            new Activity("6. Making Sprites", 9, 18, Type.Sprites, Difficulty.Low),
            
            new Activity("7. Sprites in Action", 9, 18, Type.Events, Difficulty.Low),
            new Activity("8. Virtual Pet with Sprite Lab", 9, 18, Type.Events, Difficulty.Low),
            new Activity("9. Dance Party", 9, 18, Type.Events, Difficulty.Low),
            
            new Activity("10. Loops with Rey and BB-8", 9, 18, Type.Loops, Difficulty.Low),
            new Activity("11. Mini-Project: Sticker Art", 9, 18, Type.Loops, Difficulty.Low),
            new Activity("12. Nested Loops in Maze", 9, 18, Type.Loops, Difficulty.Low),
            new Activity("13. Snowflakes with Anna and Elsa", 9, 18, Type.Loops, Difficulty.Low),
            
            new Activity("14. Looking ahead with Minecraft", 9, 18, Type.Conditionals, Difficulty.Low),
            new Activity("15. If/else with Bee", 9, 18, Type.Conditionals, Difficulty.Low),
            new Activity("16. While Loops in Farmer", 9, 18, Type.Conditionals, Difficulty.Low),
            new Activity("17. Conditionals in Minecraft: Voyage Aquatic", 9, 18, Type.Conditionals, Difficulty.Low),
            new Activity("18. Until Loops in Maze", 9, 18, Type.Conditionals, Difficulty.Low),
            new Activity("19. Harvesting with Conditionals", 9, 18, Type.Conditionals, Difficulty.Low),
            
            new Activity("20. Functions in Minecraft", 9, 18, Type.Functions, Difficulty.Low),
            new Activity("21. Functions with Harvester", 9, 18, Type.Functions, Difficulty.Low),
            new Activity("22. Functions with Artist", 9, 18, Type.Functions, Difficulty.Low),
            
            new Activity("23. Text and Prompts", 9, 18, Type.Variables, Difficulty.Low),
            new Activity("24. Counting with Variables", 9, 18, Type.Variables, Difficulty.Low),
            new Activity("25. Using Variables with the Artist", 9, 18, Type.Variables, Difficulty.Low),
            new Activity("26. Variables with the Bee", 9, 18, Type.Variables, Difficulty.Low),
            
            new Activity("27. For Loops with Bee", 9, 18, Type.Loops, Difficulty.Low),
            new Activity("28. For Loops with Artist", 9, 18, Type.Loops, Difficulty.Low),
            
            new Activity("29. End of Course Project", 9, 18, Type.Project, Difficulty.Medium),
        };
        
        // Act
        Course course = new Course(name, activities);
        
        // Assert
        Assert.Equal(name, course.Name);
        Assert.Equal(activities, course.Activities);
    }

    [Fact]
    public void Course_Constructor_WithNullActivities()
    {
        // Arrange
        string name = "12. Nested Loops in Maze";
        
        // Act
        Course course = new Course(name, null);

        // Assert
        Assert.Equal(name, course.Name);
        Assert.Null(course.Activities);
    }
}