namespace Calculator
{
    /// <summary>
    /// Muveletek felsorolasi tipusa.
    /// </summary>
    public enum Operation { None, Add, Substract, Multiply, Divide }

    /// <summary>
    /// Szamologep ablak tipusa.
    /// </summary>
    public partial class CalculatorForm : Form
    {
        #region Private fields

        private Double _result;
        private Operation _operation;

        #endregion

        #region Constructor

        /// <summary>
        /// Szamologep ablak peldanyositasa.
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            _operation = Operation.None;
            _result = 0;
            _textNumber.Text = "0";
        }

        #endregion
    }
}