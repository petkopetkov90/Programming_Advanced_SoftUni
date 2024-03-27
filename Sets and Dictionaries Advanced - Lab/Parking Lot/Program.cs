namespace Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputDetails = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = inputDetails[0];
                string plateNumber = inputDetails[1];

                if (direction == "IN")
                {
                    if (!parking.Contains(plateNumber))
                    {
                        parking.Add(plateNumber);
                    }
                }
                else
                {
                    parking.Remove(plateNumber);
                }
            }

            if (parking.Any())
            {
                Console.WriteLine(string.Join("\n", parking));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
