namespace Calculator.Model
{
    /// <summary>
    /// Művelet felsorolási típusa.
    /// </summary>
    public enum Operation { None, Add, Subtract, Multiply, Divide }

    /// <summary>
    /// Számológép típusa.
    /// </summary>
    public class CalculatorModel
    {
        #region Private fields

        private double _result;
        private Operation _operation;

        #endregion

        #region Properties

        /// <summary>
        /// Aktuális eredmény lekérdezése.
        /// </summary>
        public Double Result { get { return _result; } }

        #endregion

        #region Events

        public event EventHandler<CalculatorEventArgs>? CalculationPerformed;

        #endregion

        #region Constructor

        /// <summary>
        /// Számológép példányosítása.
        /// </summary>
        public CalculatorModel()
        {
            _result = 0;
            _operation = Operation.None;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Művelet végrehajtása.
        /// </summary>
        /// <param name="value">A második érték.</param>
        /// <param name="operation">Az új művelet.</param>
        public void Calculate(Double value, Operation operation)
        {
            string calculationString = string.Empty;

            if (_operation != Operation.None)
            {
                switch (_operation)
                {
                    case Operation.Add:
                        calculationString = _result + " + " + value + " = " + (_result + value);
                        _result = _result + value;
                        break;
                    case Operation.Subtract:
                        calculationString = _result + " - " + value + " = " + (_result - value);
                        _result = _result - value;
                        break;
                    case Operation.Multiply:
                        calculationString = _result + " * " + value + " = " + (_result * value);
                        _result = _result * value;
                        break;
                    case Operation.Divide:
                        calculationString = _result + " / " + value + " = " + (_result / value);
                        _result = _result / value;
                        break;
                }
            }
            else
            {
                _result = value;
            }

            _operation = operation;

            CalculationPerformed?.Invoke(this, new CalculatorEventArgs(_result, calculationString));
        }

        #endregion
    }
}
