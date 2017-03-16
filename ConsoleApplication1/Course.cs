namespace CentricExpress
{
    public class Course
    {
        public string Title { get; set; }

        public string ProfessorName { get; set; }

        public int CourseType { get; set; }

        public override string ToString()
        {
            return Title + ", " + ProfessorName;
        }
    } 
}
