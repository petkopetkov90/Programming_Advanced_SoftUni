namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            int daysDifference = dateModifier.DaysDifference(firstDate, secondDate);

            Console.WriteLine(Math.Abs(daysDifference));
        }
    }
}
