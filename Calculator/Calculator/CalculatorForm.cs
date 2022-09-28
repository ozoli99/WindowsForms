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

        /// <summary>
        /// Gomb esemenykezeloje.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (_operation != Operation.None)
                {
                    Double value = Double.Parse(_textNumber.Text);
                    switch (_operation)
                    {
                        case Operation.Add:
                            _listHistory.Items.Add(_result + "+" + value + "=" + (_result + value));
                            _result = _result + value;
                            break;
                        case Operation.Substract:
                            _listHistory.Items.Add(_result + "-" + value + "=" + (_result - value));
                            _result = _result - value;
                            break;
                        case Operation.Multiply:
                            _listHistory.Items.Add(_result + "*" + value + "=" + (_result * value));
                            _result = _result * value;
                            break;
                        case Operation.Divide:
                            _listHistory.Items.Add(_result + "/" + value + "=" + (_result / value));
                            _result = _result / value;
                            break;
                    }
                    _textNumber.Text = _result.ToString();
                }
                else
                {
                    _result = Double.Parse(_textNumber.Text);
                }

                if (sender is Button button)
                {
                    switch (button.Text)
                    {
                        case "+": _operation = Operation.Add; break;
                        case "-": _operation = Operation.Substract; break;
                        case "*": _operation = Operation.Multiply; break;
                        case "/": _operation = Operation.Divide; break;
                        case "=": _operation = Operation.None; break;
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Your input has too many digits!", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Your input is not a real number!\nPlease correct!", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No number in input!\nPlease correct!", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _textNumber.Focus();
                _textNumber.SelectAll();
            }
        }

        #endregion
    }
}