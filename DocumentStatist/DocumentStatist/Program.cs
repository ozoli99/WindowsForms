using DocumentStatist.Model;

namespace DocumentStatist
{
    class Program
    {
        static int Main(string[] args)
        {
            string path;
            do
            {
                Console.WriteLine("Please enter a valid text file path: ");
                path = Console.ReadLine() ?? "";
            }
            while (System.IO.Path.GetExtension(path) != ".txt" || !System.IO.File.Exists(path));

            IDocumentStatistics stat = new DocumentStatistics(path);
            try
            {
                stat.Load();
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
                return -1;
            }

            Console.WriteLine($"Character count: {stat.CharacterCount}");
            Console.WriteLine($"Non-whitespace character count: {stat.NonWhiteSpaceCharacterCount}");
            Console.WriteLine($"Sentence count: {stat.SentenceCount}");
            Console.WriteLine($"Proper noun count: {stat.ProperNounCount}");
            Console.WriteLine($"Coleman-Lieu index: {stat.ColemanLieuIndex:f2}");
            Console.WriteLine($"Flesch Reading Ease: {stat.FleschReadingEase:f2}");

            // WORD COUNT

            Console.WriteLine();
            Console.WriteLine("Parameters for word counting");
            int minLength = ReadPositive("Minimum word length: ");
            int minOccurence = ReadPositive("Minimum word occurence: ");

            Console.WriteLine();
            Console.WriteLine("Ignored words (separated by comma):");
            var ignoredWords = new List<string>();
            bool success = false;
            do
            {
                try
                {
                    string line = Console.ReadLine() ?? string.Empty;

                    ignoredWords = line.Split(',')
                        .Select(w => w.Trim().ToLower())
                        .ToList();
                    success = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect format, try again!");
                }
            } while (!success);

            var pairs = stat.DistinctWordCount
                .Where(p => p.Value >= minOccurence)
                .Where(p => p.Key.Length >= minLength)
                .Where(p => !ignoredWords.Contains(p.Key))
                .OrderByDescending(p => p.Value);

            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            return 0;
        }

        static int ReadPositive(string message)
        {
            int number;
            bool success;

            do
            {
                Console.Write(message);
                success = Int32.TryParse(Console.ReadLine(), out number) && number > 0;
            } while (!success);

            return number;
        }
    }
}