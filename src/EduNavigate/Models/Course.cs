namespace EduNavigate;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public Subject[] subjects { get; add; }
    
}