Person person = new Employee("Farid", "Huseynli", 23);
Console.WriteLine(person.ToString());

record Person(string Name);

record Employee : Person
{
    public string Surname { get; set; }
    public int Age { get; set; }

    public Employee(string name, string surname, int age) : base(name)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public override string ToString()
    {
        return $"{Name} {Surname} {Age}";
    }
}