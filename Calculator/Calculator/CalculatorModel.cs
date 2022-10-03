namespace Calculator
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
        private string _calculationString;
        private Operation _operation;

        #endregion

        #region Properties

        /// <summary>
        /// Aktuális eredmény lekérdezése.
        /// </summary>
        public Double Result { get { return _result; } }
        /// <summary>
        /// Aktuális számítás szöveges lekérdezése.
        /// </summary>
        public String CalculationString { get { return _calculationString; } }

        #endregion

        #region Constructor

        /// <summary>
        /// Számológép példányosítása.
        /// </summary>
        public CalculatorModel()
        {
            _result = 0;
            _calculationString = string.Empty;
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
            if (_operation != Operation.None)
            {
                switch (_operation)
                {
                    case Operation.Add:
                        _calculationString = _result + " + " + value + " = " + (_result + value);
                        _result = _result + value;
                        break;
                    case Operation.Subtract:
                        _calculationString = _result + " - " + value + " = " + (_result - value);
                        _result = _result - value;
                        break;
                    case Operation.Multiply:
                        _calculationString = _result + " * " + value + " = " + (_result * value);
                        _result = _result * value;
                        break;
                    case Operation.Divide:
                        _calculationString = _result + " / " + value + " = " + (_result / value);
                        _result = _result / value;
                        break;
                }
            }
            else
            {
                _result = value;
            }

            _operation = operation;
        }

        #endregion
    }
}
