namespace CentricExpress
{
    public class StudentRepository
    {
        public Student Retrieve(int studentId)
        {
            var student = new Student(studentId);

            //Code that gets student data from DB
            student.FirstName = "Ana";
            student.LastName = "Blandiana";

            return student;
        }

        public void Save(Student student)
        {
            //Code that writes student data
            //into the database
        }
    }
}
