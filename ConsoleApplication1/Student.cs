namespace CentricExpress
{
    public class Student
    {
        public Student(int studentId)
        {
            this.Id = studentId;
        }

        public int Id { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address HomeAddress { get; set; }

        public Address CurrentAddress { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
    