class Course(string name, int capacity)
{
    // public fields
    public string Name = name;
    public int Capacity = capacity;
    public List<Student> Students = [];
    
    //enroll method checking if course contains student
    //if not add student to course and add course to student
    public void Enroll(Student student)
    {
        if(!Students.Contains(student))
        {
            Students.Add(student);
            student.Courses.Add(this);
        }
    }
}