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

        #region Event handlers

        /// <summary>
        /// Idozito esemenykezeloje.
        /// </summary>
        private void Timer_Tick(object? sender, EventArgs e)
        {
            int number = _questionGenerator.Next(1, _questionCount + 1);
            while (_historyList.Contains(number))
                number = _questionGenerator.Next(1, _questionCount + 1);
            _textNumber.Text = number.ToString();
        }

        /// <summary>
        /// Start gomb esemenykezeloje.
        /// </summary>
        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            if (!_timer.Enabled)
            {
                _timer.Start();
                _buttonStart.Text = "STOP";
            }
            else
            {
                _historyList.Insert(0, int.Parse(_textNumber.Text));

                if (_historyList.Count > _periodLength)
                    _historyList.RemoveAt(_historyList.Count - 1);

                _timer.Stop();
                _buttonStart.Text = "START";
            }
        }

        #endregion
    }
}