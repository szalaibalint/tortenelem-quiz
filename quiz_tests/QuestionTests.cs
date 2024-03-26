using System.Runtime.InteropServices.JavaScript;
using quiz;

namespace quiz_tests;

[TestClass]
public class QuestionTests {
    [TestMethod]
    [DeploymentItem(@"TestFiles\singleselect.json")]
    public void SingleSelectQuestionTest()
    {
        SelectionQuestion question = Question.LoadFromJSON("singleselect.json") as SelectionQuestion;

        List<Answer> answers = new() { new Answer("text1", false), new("text2", false), new("text3", true), new("text4", false) };

        Assert.AreEqual("gyuri", question.Text);
        Assert.AreEqual(false, question.Multiselect);
        CollectionAssert.AreEqual(answers, question.Answers);
    }

    [TestMethod]
    [DeploymentItem("TestFiles/truefalse.json")]
    public void TrueFalseQuestionTest()
    {
        TrueFalseQuestion question = Question.LoadFromJSON("truefalse.json") as TrueFalseQuestion;

        Assert.AreEqual("gyuri on top?", question.Text);
        Assert.AreEqual(true, question.IsCorrect);
    }

    [TestMethod]
    [DeploymentItem("TestFiles/date.json")]
    public void DateQuestionTest()
    {
        DateQuestion question = Question.LoadFromJSON("date.json") as DateQuestion;

        Assert.AreEqual("mikor született gyuri?", question.Text);
        Assert.AreEqual(1961, question.Answer);
    }

    [TestMethod]
    [DeploymentItem("TestFiles/multiselect.json")]
    public void MultiSelectQuestionTest()
    {
        SelectionQuestion question = Question.LoadFromJSON("multiselect.json") as SelectionQuestion;
        List<Answer> answers = new() { new Answer("t1", false), new("t2", true), new("t3", true), new("t4", false) };

        Assert.AreEqual("multiselect question", question.Text);
        Assert.AreEqual(true, question.Multiselect);
        CollectionAssert.AreEqual(answers, question.Answers);
    }
}