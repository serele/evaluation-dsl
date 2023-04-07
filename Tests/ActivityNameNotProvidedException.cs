namespace Tests;

public class ActivityNameNotProvidedException : Exception
{
    public override string Message => "Activity name can't be empty";
}