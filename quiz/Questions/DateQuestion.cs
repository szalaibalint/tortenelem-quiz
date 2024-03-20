namespace quiz;

public class DateQuestion : Question {
    private int answer;

    public int Answer => answer;

    public DateQuestion(string text, int answer) : base(text)
    {
        this.answer = answer;
    }
}