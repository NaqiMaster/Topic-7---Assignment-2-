using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Topic_7___Assignment__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> veg = new List<string>();

            

            veg.Add("CARROTS");
            veg.Add("BEET");
            veg.Add("CELERY");
            veg.Add("RADISH");
            veg.Add("CABBAGE");
            int user;
            user = 0;

            while (user != 6)
            {
                Console.Clear();
                for (int i = 0; i < veg.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. " + veg[i]);

                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Select one of the options:");
                Console.WriteLine("1. Remove vegetable by index");
                Console.WriteLine("2. Remove vegetable by value");
                Console.WriteLine("3. Search for vegetable");
                Console.WriteLine("4. Add vegetable");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Quit");
                Console.WriteLine();

                user = Convert.ToInt32(Console.ReadLine());

                if (user == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("# of index you want to remove?");
                    veg.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                }
                else if (user == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Value you want to remove?");
                    veg.Remove(Console.ReadLine().ToUpper());
                }
                else if (user == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("What are you searching for?");
                    string input = Console.ReadLine().ToUpper();

                    for (int j = 0; j < veg.Count; j++)
                    {
                        if (veg[j] == input)
                        {
                            Console.WriteLine($"Index of {veg[j + 1]} is {j}");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else if (user == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("What vegetable do you want to add?");
                    veg.Add(Console.ReadLine().ToUpper());
                }
                else if (user == 5)
                {
                    veg.Sort();
                }
            }

            Console.WriteLine("Thanks for using this application!");
        }
    }
}