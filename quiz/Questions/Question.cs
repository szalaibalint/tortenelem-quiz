using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace quiz;

public abstract class Question {
    private string text;

    public string Text => text;

    protected Question(string text)
    {
        this.text = text;
    }

    public static Question LoadFromJSON(string path)
    {
        string file = File.ReadAllText(path);
        JsonNode json = JsonNode.Parse(file);

        string type = json["type"].ToString();
        string text = json["text"].ToString();
  


        switch (type)
        {
            case "single":
            case "multi":
                List<Answer> answers = new();
                JsonArray jsonArray = json["answers"].AsArray();
                foreach (JsonObject ans in jsonArray)
                {
                    answers.Add(new Answer(ans["text"].ToString(), ans["correct"].GetValue<bool>()));
                }

                return new SelectionQuestion(text, answers, type == "multi");
            case "truefalse":
                return new TrueFalseQuestion(text, json["correct"].GetValue<bool>());
            case "date":
                return new DateQuestion(text, json["answer"].GetValue<int>());
            case "order":
                List<NumericAnswer> numericAnswers = new();
                JsonArray jsonArray1 = json["answers"].AsArray();
                foreach(JsonObject ans in jsonArray1)
                {
                    numericAnswers.Add(new NumericAnswer(ans["text"].ToString(), ans["correct"].GetValue<int>()));
                }

                return new OrderQuestion(text, numericAnswers);
        }
        return null;
    }
}