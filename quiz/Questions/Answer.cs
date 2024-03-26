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

public struct NumericAnswer {
    public string text;
    public int correct;

    public NumericAnswer(string text, int correct)
    {
        this.text = text;
        this.correct = correct;
    }
}