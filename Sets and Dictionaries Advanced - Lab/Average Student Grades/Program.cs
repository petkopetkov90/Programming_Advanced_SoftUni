namespace Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsGrades = new();

            for (int i = 0; i < inputsCount; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string Name = studentInfo[0];
                decimal grade = decimal.Parse(studentInfo[1]);

                if (!studentsGrades.ContainsKey(Name))
                {
                    studentsGrades.Add(Name, new List<decimal>());
                }

                studentsGrades[Name].Add(grade);
            }

            foreach (KeyValuePair<string, List<decimal>> studentGrades in studentsGrades)
            {
                Console.WriteLine($"{studentGrades.Key} -> {string.Join(" ", studentGrades.Value.Select(g => $"{g:f2}"))} (avg: {studentGrades.Value.Average():f2})");
            }
        }
    }
}
