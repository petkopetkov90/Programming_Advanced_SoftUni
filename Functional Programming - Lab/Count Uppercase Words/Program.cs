namespace Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] words = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(w => char.IsUpper(w[0]))
            //    .ToArray();

            //string[] words = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .ToArray();

            //Predicate<string> startWithUppercase = word => char.IsUpper(word[0]);

            //Func<string[], Predicate<string>, List<string>> checkForWordsWithUppercase = (words, predicate) =>
            //{
            //    List<string> wordsWithUpperCase = new List<string>();

            //    foreach (var word in words)
            //    {
            //        if (predicate(word))
            //        {
            //            wordsWithUpperCase.Add(word);
            //        }
            //    }

            //    return wordsWithUpperCase;
            //};

            //List<string> wordsWithUpperCase = checkForWordsWithUppercase(words, startWithUppercase);

            //Console.WriteLine(string.Join(Environment.NewLine, wordsWithUpperCase));

            Func<string, bool> checkForUppercase = word => char.IsUpper(word[0]);

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checkForUppercase)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
