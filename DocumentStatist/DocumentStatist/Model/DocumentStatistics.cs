namespace DocumentStatist.Model
{
    public class DocumentStatistics : IDocumentStatistics
    {
        #region Private fields

        private readonly string _filePath;

        #endregion

        #region Properties

        public string FileContent { get; private set; }

        public IDictionary<string, int> DistinctWordCount { get; private set; }

        public int CharacterCount => FileContent.Length;
        public int NonWhiteSpaceCharacterCount { get; private set; }
        public int SentenceCount { get; private set; }
        public int ProperNounCount { get; private set; }
        public double ColemanLieuIndex { get; private set; }
        public double FleschReadingEase { get; private set; }

        #endregion

        #region Constructor

        public DocumentStatistics(string filePath)
        {
            _filePath = filePath;
            FileContent = string.Empty;
            DistinctWordCount = new Dictionary<string, int>();
        }

        #endregion

        #region Public methods

        public void Load()
        {
            FileContent = File.ReadAllText(_filePath);
            NonWhiteSpaceCharacterCount = FileContent.Count(c => !char.IsWhiteSpace(c));

            ComputeDistinctWords();
            SentenceCount = ComputeSentenceCount();
            ProperNounCount = ComputeProperNounCount();
            ColemanLieuIndex = ComputeColemanLieuIndex();
            FleschReadingEase = ComputeFleschReadingEase();
        }

        #endregion
    }
}
