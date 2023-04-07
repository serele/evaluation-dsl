using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

namespace Tests;

public class ActivityTests
{
    private readonly Activity _activity;

    public ActivityTests()
    {
        _activity = new Activity("Actividad 1", 8, 12, Type.Loops, Difficulty.Low);
    }

    [Fact]
    public string TestSetActivityName()
    {
        if (string.IsNullOrEmpty(_activity.Name))
            throw new ActivityNameNotProvidedException();
        
        return _activity.Name;
    }
}