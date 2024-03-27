using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; private set; }
        public List<Shark> Species { get; private set; }
        public int GetCount => Species.Count;

        public void AddShark(Shark shark)
        {
            if (Species.Count < Capacity && !Species.Any(s => s.Kind == shark.Kind))
            {
                Species.Add(shark);
            }
        }

        public bool RemoveShark(string kind)
        {
            Shark shark = Species.FirstOrDefault(s => s.Kind == kind);

            if (shark != null)
            {
                Species.Remove(shark);
                return true;
            }

            return false;
        }

        public string GetLargestShark()
        {
            return Species.MaxBy(s => s.Length).ToString();
        }

        public double GetAverageLength()
        {
            return Species.Average(s => s.Length);
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Species.Count} sharks classified:");

            foreach (Shark shark in Species)
            {
                stringBuilder.AppendLine(shark.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
