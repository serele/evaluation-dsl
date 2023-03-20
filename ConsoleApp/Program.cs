using EvaluationDSL.Entities;
using Type = EvaluationDSL.Entities.Type;

Activity activity1 = new Activity("Actividad 1", 8, 12, Type.Loops, Difficulty.Low);
Activity activity2 = new Activity("Actividad 2", 10, 12, Type.Conditions, Difficulty.Low);

Console.WriteLine(activity1.Id);
Console.WriteLine(activity1.Name);

Console.WriteLine(activity2.Id);
Console.WriteLine(activity2.Name);

Console.ReadKey();

