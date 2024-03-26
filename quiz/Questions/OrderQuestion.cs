namespace quiz;

public class OrderQuestion: Question {
    private List<NumericAnswer> answers;

    public List<NumericAnswer> Answers => answers;

    public OrderQuestion(string text, List<NumericAnswer> answers) : base(text)
    {
        this.answers = answers;
    }
}