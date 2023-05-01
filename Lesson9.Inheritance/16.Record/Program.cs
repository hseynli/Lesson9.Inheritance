Person person = new Person("Farid", "Huseynli");
(string name, _) = person.GetPersonInfo();

Console.WriteLine(name);

record Person
{
    private readonly string name;
    private readonly string surname;

    public string Name { get { return name; } }
    public string Surname { get { return surname; } }

    public Person(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public (string, string) GetPersonInfo()
    {
        return (Name, Surname);
    }
}