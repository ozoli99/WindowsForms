namespace DocumentStatist.Model
{
    public interface IDocumentStatistics
    {
        IDictionary<string, int> DistinctWordCount { get; }
        int CharacterCount { get; }
        int NonWhiteSpaceCharacterCount { get; }
        int SentenceCount { get; }
        int ProperNounCount { get; }
        double ColemanLieuIndex { get; }
        double FleschReadingEase { get; }

        void Load();
    }
}
