Course math = new("Mathematics", 5);
Course eng = new("English", 5);
Course phys = new("Physics", 5);
Course sport = new("Sports", 5);

Student anna = new("Anna Anderson");
Student bert = new("Bert Bertson");
Student carl = new("Carl Carlson");
Student david = new("David Davidson");
Student eric = new("Eric Ericson");
Student filip = new("Filip Filipson");

math.Enroll(anna);
anna.Join(eng);
phys.Enroll(anna);
sport.Enroll(anna);
math.Enroll(bert);
math.Enroll(carl);
math.Enroll(david);
math.Enroll(eric);
math.Enroll(filip);

foreach (Course c in anna.Courses)
{
    Console.WriteLine(c.Name);
}

foreach (Student c in math.Students)
{
    Console.WriteLine(c.Name);
}