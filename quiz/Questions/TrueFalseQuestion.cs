namespace quiz;

public class TrueFalseQuestion : Question {
    private bool correct;

    public bool IsCorrect => correct;

    public TrueFalseQuestion(string text, bool correct) : base(text)
    {
        this.correct = correct;
    }
}