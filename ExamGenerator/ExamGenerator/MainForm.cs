namespace ExamGenerator
{
    /// <summary>
    /// Foablak tipusa.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Private fields

        private System.Windows.Forms.Timer _timer;
        private Random _questionGenerator;
        private int _questionCount;
        private int _periodLength;
        private List<int> _historyList;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }
    }
}