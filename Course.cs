class Course(string name, int capacity)
{
    // public fields
    public string Name = name;
    public int Capacity = capacity;
    public List<Student> Students = [];
    
    // enroll method checking if course contains student and checking if the course
    // has capacity for more students
    // if not add student to course and add course to student and
    public void Enroll(Student student)
    {
        if(!Students.Contains(student) && Students.Count < Capacity)
        {
            Students.Add(student);
            student.Courses.Add(this);
        }
        else
        {
            Console.WriteLine("Sorry, this course is full.");
        }
    }
    // removes said student from course IF 
    // student is enrolled into course
    public void Remove(Student student)
    {
        if(Students.Contains(student))
        {
            Students.Remove(student);
            student.Courses.Remove(this);
        }
    }
    // prints out all enrolled students
    // in a course 
    public void RollCall()
    {
        foreach(Student c in Students)
        {
            Console.WriteLine(c.Name);
        }
    }

}