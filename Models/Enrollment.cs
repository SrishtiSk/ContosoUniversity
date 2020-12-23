namespace ContosoUniversity.Models
{
    public enum Grade { A, B, C, D, F}
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; } /// <summary>
                                          /// The Grade property is an enum. The ? after the Grade type 
                                          /// declaration indicates that the Grade property is nullable.
                                          /// A grade that's null is different from a zero grade.
                                          /// null means a grade isn't known or hasn't been assigned yet.
                                          /// </summary>
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}