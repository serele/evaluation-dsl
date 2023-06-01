using EvaluationDSL.Entities;
using Newtonsoft.Json.Linq;
using Type = EvaluationDSL.Entities.Type;

try
{
    using (var sr = new StreamReader(@"C:\code.org\alu001_express-2021.json"))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
    
    const string fileName = @"C:\code.org\alu001_express-2021.json";
    var jsonString = File.ReadAllText(fileName);
    // var jToken = JToken.Parse(jsonString);
    
    var jObject = JObject.Parse(jsonString);
    var lessonsJToken = jObject["lessons"].ToList();
    

    var courseJToken = jObject.Children<JProperty>().FirstOrDefault(x => x.Name == "course").Value;
    var studentJToken = jObject.Children<JProperty>().FirstOrDefault(x => x.Name == "student").Value;
    // var lessonsJToken = jObject.Children<JProperty>().FirstOrDefault(x => x.Name == "lessons").Value;
    
    var lessons = new List<Lesson>();
    var activities = new List<Activity>();
    
    foreach (var lesson in lessonsJToken)
    {
        var l = new Lesson();
        // TODO: averiguar como hacer la conversión..... 
        l.Type = lesson["type"].ToObject<Type>();
        l.Name = lesson["Name"].ToObject<string>();
        
        // lessons.Add(lesson.ToObject<Lesson>());
        var activitiesJToken = lesson.Children<JProperty>().FirstOrDefault(x => x.Name == "activities").Value;
        activities.AddRange(activitiesJToken.Select(activity => activity.ToObject<Activity>()));
        l.Activities = activities;
    }
    
    // var activitiesJToken = lessonsJToken.Children<JProperty>().FirstOrDefault(x => x.Name == "activities").Value;


}
catch (IOException e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}