namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLinesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> coloredClothesCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputLinesCount; i++)
            {
                string[] currentColoredClothes = Console.ReadLine().Split(new string[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = currentColoredClothes[0];

                if (!coloredClothesCount.ContainsKey(color))
                {
                    coloredClothesCount.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < currentColoredClothes.Length; j++)
                {
                    string currentWear = currentColoredClothes[j];

                    if (!coloredClothesCount[color].ContainsKey(currentWear))
                    {
                        coloredClothesCount[color].Add(currentWear, 0);
                    }

                    coloredClothesCount[color][currentWear]++;
                }
            }

            string[] searchForWear = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorToFind = searchForWear[0];
            string wearToFind = searchForWear[1];

            foreach (var colorClothers in coloredClothesCount)
            {
                Console.WriteLine($"{colorClothers.Key} clothes:");

                foreach (var wearCount in colorClothers.Value)
                {
                    string textToPrint = $"* {wearCount.Key} - {wearCount.Value}";

                    if (colorClothers.Key == colorToFind && wearCount.Key == wearToFind)
                    {
                        textToPrint += " (found!)";
                    }

                    Console.WriteLine(textToPrint);
                }
            }
        }
    }
}
