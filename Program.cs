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

math.RollCall();
anna.Schedule();
Console.WriteLine(math);
Console.WriteLine(anna);
bert.Leave(eng);
math.RollCall();
filip.Join(eng);
Console.WriteLine(eng);
eng.RollCall();
Console.WriteLine(filip);
filip.Schedule();
math.Enroll(anna);
math.Enroll(anna);