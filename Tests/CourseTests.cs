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
        
        List<Lesson> lessons = new List<Lesson>()
        {
            new Lesson("1. Programming with Angry Birds", 9, 18, Type.Sequencing, Difficulty.Low, activities1),
            new Lesson("2. Debugging in Maze", 9, 18, Type.Sequencing, Difficulty.Low, activities2),
            new Lesson("3. Collecting Treasure with Laurel", 9, 18, Type.Sequencing, Difficulty.Low, activities3),
            new Lesson("4. Creating Art with Code", 9, 18, Type.Sequencing, Difficulty.Low, activities4),
            
            new Lesson("5. Swimming Fish in Sprite Lab", 9, 18, Type.Sprites, Difficulty.Low, activities5),
            new Lesson("6. Making Sprites", 9, 18, Type.Sprites, Difficulty.Low, activities6),
            
            new Lesson("7. Sprites in Action", 9, 18, Type.Events, Difficulty.Low, activities1),
            new Lesson("8. Virtual Pet with Sprite Lab", 9, 18, Type.Events, Difficulty.Low, activities2),
            new Lesson("9. Dance Party", 9, 18, Type.Events, Difficulty.Low, activities3),
            
            new Lesson("10. Loops with Rey and BB-8", 9, 18, Type.Loops, Difficulty.Low, activities4),
            new Lesson("11. Mini-Project: Sticker Art", 9, 18, Type.Loops, Difficulty.Low, activities5),
            new Lesson("12. Nested Loops in Maze", 9, 18, Type.Loops, Difficulty.Low, activities6),
            new Lesson("13. Snowflakes with Anna and Elsa", 9, 18, Type.Loops, Difficulty.Low, activities1),
            
            new Lesson("14. Looking ahead with Minecraft", 9, 18, Type.Conditionals, Difficulty.Low, activities1),
            new Lesson("15. If/else with Bee", 9, 18, Type.Conditionals, Difficulty.Low, activities2),
            new Lesson("16. While Loops in Farmer", 9, 18, Type.Conditionals, Difficulty.Low, activities3),
            new Lesson("17. Conditionals in Minecraft: Voyage Aquatic", 9, 18, Type.Conditionals, Difficulty.Low, activities4),
            new Lesson("18. Until Loops in Maze", 9, 18, Type.Conditionals, Difficulty.Low, activities5),
            new Lesson("19. Harvesting with Conditionals", 9, 18, Type.Conditionals, Difficulty.Low, activities6),
            
            new Lesson("20. Functions in Minecraft", 9, 18, Type.Functions, Difficulty.Low, activities1),
            new Lesson("21. Functions with Harvester", 9, 18, Type.Functions, Difficulty.Low, activities2),
            new Lesson("22. Functions with Artist", 9, 18, Type.Functions, Difficulty.Low, activities3),
            
            new Lesson("23. Text and Prompts", 9, 18, Type.Variables, Difficulty.Low, activities1),
            new Lesson("24. Counting with Variables", 9, 18, Type.Variables, Difficulty.Low, activities2),
            new Lesson("25. Using Variables with the Artist", 9, 18, Type.Variables, Difficulty.Low, activities3),
            new Lesson("26. Variables with the Bee", 9, 18, Type.Variables, Difficulty.Low, activities4),
            
            new Lesson("27. For Loops with Bee", 9, 18, Type.Loops, Difficulty.Low, activities1),
            new Lesson("28. For Loops with Artist", 9, 18, Type.Loops, Difficulty.Low, activities2),
            
            new Lesson("29. End of Course Project", 9, 18, Type.EndOfCourseProject, Difficulty.Medium, activities1),
        };
        
        // Act
        Course course = new Course(name, lessons);
        
        // Assert
        Assert.Equal(name, course.Name);
        Assert.Equal(lessons, course.Lessons);
    }

    [Fact]
    public void Course_IdIsUnique()
    {
        // Arrange
        string courseName1 = "Express Course";
        string courseName2 = "Advanced Course";
        
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
            new Activity("2.4")
        };
        List<Activity> activities3 = new List<Activity>()
        {
            new Activity("10.1"),
            new Activity("10.2"),
            new Activity("10.4")
        };
        List<Activity> activities4 = new List<Activity>()
        {
            new Activity("11.1"),
            new Activity("11.2"),
            new Activity("11.4")
        };

        Lesson lesson1 = new Lesson("1. Programming with Angry Birds", 9, 18, Type.Events, Difficulty.Low, activities1);
        Lesson lesson2 = new Lesson("2. Debugging in Maze", 9, 18, Type.Sequencing, Difficulty.Low, activities2);
        List<Lesson> lessons1 = new List<Lesson>();
        lessons1.Add(lesson1);
        lessons1.Add(lesson2);
        
        Lesson lesson3 = new Lesson("1. Operators", 9, 18, Type.Events, Difficulty.Low, activities3);
        Lesson lesson4 = new Lesson("2. Linked lists", 9, 18, Type.Sequencing, Difficulty.Low, activities4);
        List<Lesson> lessons2 = new List<Lesson>();
        lessons2.Add(lesson3);
        lessons2.Add(lesson4);

        // Act
        Course course1 = new Course(courseName1, lessons1);
        Course course2 = new Course(courseName2, lessons2);

        // Assert
        Assert.NotEqual(course1.Id, course2.Id);

    }
}