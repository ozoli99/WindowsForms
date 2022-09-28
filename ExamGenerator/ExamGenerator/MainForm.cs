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

        #region Constructor

        /// <summary>
        /// Foablak peldanyositasa.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _historyList = new List<int>();
            _questionGenerator = new Random();
            _questionCount = 10;
            _periodLength = 0;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 20;
            _timer.Tick += new EventHandler(Timer_Tick);
        }

        #endregion
    }
}