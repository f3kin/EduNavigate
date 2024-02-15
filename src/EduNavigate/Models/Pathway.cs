namespace EduNavigate;

public class Pathway
{
    public int PathwayId { get; set; }

    //[This is a data annotation]
    public string PathwayName { get; set; }
    public List<Course> Courses { get; set; }
    // Add other properties as needed
    public Pathway(string PathwayName, List<Course> Courses){
        this.Courses = Courses;
        this.PathwayName = PathwayName;
    }
}