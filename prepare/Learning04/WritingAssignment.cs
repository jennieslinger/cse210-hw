public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        :base(studentName, topic)
    {
        //Variable specific to WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        //Call getter here because _studentName private in base class 
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}