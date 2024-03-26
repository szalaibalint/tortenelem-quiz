namespace quiz;

public class SelectionQuestion : Question {
    private List<Answer> answers;
    private bool multiselect;

    public List<Answer> Answers => answers;
    public bool Multiselect => multiselect;

    public SelectionQuestion(string text, List<Answer> answers, bool multiselect = false) : base(text)
    {
        this.answers = answers;
        this.multiselect = multiselect;
    }
}