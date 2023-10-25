public class Assignment
{
    private string StudentName;
    private string Topic;
    public Assignment(string studentName, string topic)
    {
        StudentName = studentName;
        Topic = topic;
    }

    public string GetStudentName()
    {
        return StudentName;
    }

    public string GetTopic()
    {
        return Topic;
    }

    public string GetSummary()
    {
        return StudentName + " - " + Topic;
    }
}