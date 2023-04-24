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
        
        List<Lesson> activities = new List<Lesson>()
        {
            new Lesson("1. Programming with Angry Birds", 9, 18, Type.Sequences, Difficulty.Low, exercises1),
            new Lesson("2. Debugging in Maze", 9, 18, Type.Sequences, Difficulty.Low, exercises2),
            new Lesson("3. Collecting Treasure with Laurel", 9, 18, Type.Sequences, Difficulty.Low, exercises3),
            new Lesson("4. Creating Art with Code", 9, 18, Type.Sequences, Difficulty.Low, exercises4),
            
            new Lesson("5. Swimming Fish in Sprite Lab", 9, 18, Type.Sprites, Difficulty.Low, exercises5),
            new Lesson("6. Making Sprites", 9, 18, Type.Sprites, Difficulty.Low, exercises6),
            
            new Lesson("7. Sprites in Action", 9, 18, Type.Events, Difficulty.Low, exercises1),
            new Lesson("8. Virtual Pet with Sprite Lab", 9, 18, Type.Events, Difficulty.Low, exercises2),
            new Lesson("9. Dance Party", 9, 18, Type.Events, Difficulty.Low, exercises3),
            
            new Lesson("10. Loops with Rey and BB-8", 9, 18, Type.Loops, Difficulty.Low, exercises4),
            new Lesson("11. Mini-Project: Sticker Art", 9, 18, Type.Loops, Difficulty.Low, exercises5),
            new Lesson("12. Nested Loops in Maze", 9, 18, Type.Loops, Difficulty.Low, exercises6),
            new Lesson("13. Snowflakes with Anna and Elsa", 9, 18, Type.Loops, Difficulty.Low, exercises1),
            
            new Lesson("14. Looking ahead with Minecraft", 9, 18, Type.Conditionals, Difficulty.Low, exercises1),
            new Lesson("15. If/else with Bee", 9, 18, Type.Conditionals, Difficulty.Low, exercises2),
            new Lesson("16. While Loops in Farmer", 9, 18, Type.Conditionals, Difficulty.Low, exercises3),
            new Lesson("17. Conditionals in Minecraft: Voyage Aquatic", 9, 18, Type.Conditionals, Difficulty.Low, exercises4),
            new Lesson("18. Until Loops in Maze", 9, 18, Type.Conditionals, Difficulty.Low, exercises5),
            new Lesson("19. Harvesting with Conditionals", 9, 18, Type.Conditionals, Difficulty.Low, exercises6),
            
            new Lesson("20. Functions in Minecraft", 9, 18, Type.Functions, Difficulty.Low, exercises1),
            new Lesson("21. Functions with Harvester", 9, 18, Type.Functions, Difficulty.Low, exercises2),
            new Lesson("22. Functions with Artist", 9, 18, Type.Functions, Difficulty.Low, exercises3),
            
            new Lesson("23. Text and Prompts", 9, 18, Type.Variables, Difficulty.Low, exercises1),
            new Lesson("24. Counting with Variables", 9, 18, Type.Variables, Difficulty.Low, exercises2),
            new Lesson("25. Using Variables with the Artist", 9, 18, Type.Variables, Difficulty.Low, exercises3),
            new Lesson("26. Variables with the Bee", 9, 18, Type.Variables, Difficulty.Low, exercises4),
            
            new Lesson("27. For Loops with Bee", 9, 18, Type.Loops, Difficulty.Low, exercises1),
            new Lesson("28. For Loops with Artist", 9, 18, Type.Loops, Difficulty.Low, exercises2),
            
            new Lesson("29. End of Course Project", 9, 18, Type.Project, Difficulty.Medium, exercises1),
        };
        
        // Act
        Course course = new Course(name, activities);
        
        // Assert
        Assert.Equal(name, course.Name);
        Assert.Equal(activities, course.Lessons);
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

        Lesson lesson1 = new Lesson("1. Programming with Angry Birds", 9, 18, Type.Events, Difficulty.Low, exercises1);
        Lesson lesson2 = new Lesson("2. Debugging in Maze", 9, 18, Type.Sequences, Difficulty.Low, exercises2);
        List<Lesson> lessons = new List<Lesson>();
        lessons.Add(lesson1);
        lessons.Add(lesson2);
        
        Lesson lesson3 = new Lesson("1. Operators", 9, 18, Type.Events, Difficulty.Low, exercises3);
        Lesson lesson4 = new Lesson("2. Linked lists", 9, 18, Type.Sequences, Difficulty.Low, exercises4);
        List<Lesson> activities2 = new List<Lesson>();
        lessons.Add(lesson3);
        lessons.Add(lesson4);

        // Act
        Course course1 = new Course(courseName1, lessons);
        Course course2 = new Course(courseName2, activities2);

        // Assert
        Assert.NotEqual(course1.Id, course2.Id);

    }
}