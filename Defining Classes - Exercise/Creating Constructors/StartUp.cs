namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name = "Peter";
            peter.Age = 20;

            Person george = new Person(18);
            george.Name = "George";

            Person jose = new Person("Jose", 43);
        }
    }
}
