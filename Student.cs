class Student(string name)
{
    public string Name = name;
    public List<Course> Courses = [];

    public void Join(Course course)
    {
        course.Enroll(this);
    }
}