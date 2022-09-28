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
        }
    }
}