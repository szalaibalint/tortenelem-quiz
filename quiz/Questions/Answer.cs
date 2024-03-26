namespace quiz;

public struct Answer {
    public string text;
    public bool correct;

    public Answer(string text, bool correct)
    {
        this.text = text;
        this.correct = correct;
    }
}