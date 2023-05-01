Clock clock = new Clock { Hours = 15, Minutes = 34, Seconds = 53 };
Console.WriteLine(clock.ToString());


class Clock : Object
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public override string ToString()
    {
        return $"{Hours}:{Minutes}:{Seconds}";
    }
}