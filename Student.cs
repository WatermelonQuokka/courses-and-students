class Student(string name)
{
    public string Name = name;
    public List<Course> Courses = [];


    // same purpose as course enroll which is 
    // why its calling the enroll method
    public void Join(Course course)
    {
        course.Enroll(this);
    }
    // similar as above
    public void Leave(Course course)
    {
        course.Remove(this);
    }
    
    // prints out all courses the student is attending
    public void Schedule()
    {
        foreach(Course c in Courses)
        {
            Console.WriteLine(c.Name);
        }
    }
    
    // prints out full name of student
    public override string ToString()
    {
        return Name;
    }
}