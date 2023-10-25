public class MathAssignment : Assignment
{
    private string TextbookSection;
    private string Problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        TextbookSection = textbookSection;
        Problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {TextbookSection} Problems {Problems}";
    }
}