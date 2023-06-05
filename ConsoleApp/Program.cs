using EvaluationDSL.Entities;
using Newtonsoft.Json.Linq;

try
{
    const string fileName = @"../../../resources/alu001_express-2021.json";
    var jsonString = File.ReadAllText(fileName);
    var jObject = JObject.Parse(jsonString);
    var lessons = new List<Lesson>();
    var lessonsJToken1 = jObject.Children<JProperty>().FirstOrDefault(x => x.Name == "lessons").Value;
    
    lessons.AddRange(lessonsJToken1.Select(activity => activity.ToObject<Lesson>()));

    var evaluations = lessons.Select(lesson => new Evaluation(lesson)).ToList();
    
    foreach (var evaluation in evaluations)
    {
        // var score = float.IsNaN(evaluation.Score) ? 0 : evaluation.Score;
        Console.WriteLine($"LESSON: {evaluation.Lesson.Name} \nSCORE: {evaluation.Score}\n");
    }
}
catch (IOException e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}