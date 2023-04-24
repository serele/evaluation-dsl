using EvaluationDSL.Entities;

namespace Tests;

public class ActivityTests
{
    [Fact]
    public void Activity_Constructor_SetsProperties()
    {
        // Arrange
        string id = "8.2";
        Activity activity = new Activity(id);
        
        // Assert
        Assert.Equal(id, activity.Id);
    }
    
    [Fact]
    public void Activity_IdIsUnique()
    {
        // Arrange
        Activity activity1 = new Activity("1.1");
        Activity activity2 = new Activity("8.4");

        // Assert
        Assert.NotEqual(activity1.Id, activity2.Id);
    }
}