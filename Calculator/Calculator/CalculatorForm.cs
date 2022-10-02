namespace Calculator
{
    /// <summary>
    /// Szamologep ablak tipusa.
    /// </summary>
    public partial class CalculatorForm : Form
    {
        #region Private fields

        private CalculatorModel _model;

        #endregion

        #region Constructor

        /// <summary>
        /// Szamologep ablak peldanyositasa.
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            _model = new CalculatorModel();
            _textNumber.Text = _model.Result.ToString();

            KeyPreview = true;
            KeyDown += new KeyEventHandler(CalculatorForm_KeyDown);
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Gomb eseménykezelõje.
        /// </summary>
        private void Button_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Text)
                {
                    case "+":
                        PerformCalculation(Operation.Add);
                        break;
                    case "-":
                        PerformCalculation(Operation.Subtract);
                        break;
                    case "*":
                        PerformCalculation(Operation.Multiply);
                        break;
                    case "/":
                        PerformCalculation(Operation.Divide);
                        break;
                    default:
                        PerformCalculation(Operation.None);
                        break;
                }
            }
        }

        /// <summary>
        /// Billentyû eseménykezelõje.
        /// </summary>
        private void CalculatorForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    PerformCalculation(Operation.Add);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Subtract:
                    PerformCalculation(Operation.Subtract);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Multiply:
                    PerformCalculation(Operation.Multiply);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Divide:
                    PerformCalculation(Operation.Divide);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Enter:
                    PerformCalculation(Operation.None);
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        #endregion


    }
}