namespace GenericScale
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<string> scale = new EqualityScale<string>("aa", "aaa");
            Console.WriteLine(scale.AreEqual());
        }
    }
}
