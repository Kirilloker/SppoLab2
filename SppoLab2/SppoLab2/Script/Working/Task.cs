using System.Text.Json.Serialization;

namespace SppoLab2.Script.Workinging;

public class Task : GetInfo
{
    private string text;

    [JsonConstructor]
    public Task(string str)
    {
        text = str;
    }

    public string GetFullInfo()
    {
        return text;
    }

    public string GetShortInfo()
    {
        return text;
    }

    // Test Save
    public string Text { get { return text; } set { text = value; } }

    public Task()
    {
        text = "Пусто";
    }
}