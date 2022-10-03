namespace Calculator.Model
{
    /// <summary>
    /// Számológép eseményargumentum típusa.
    /// </summary>
    public class CalculatorEventArgs : EventArgs
    {
        #region Private fields

        private double _result;
        private string _calculationString;

        #endregion

        #region Properties

        /// <summary>
        /// Eredmény lekérdezése.
        /// </summary>
        public double Result { get { return _result; } }
        /// <summary>
        /// Számítás szöveges lekérdezése.
        /// </summary>
        public string CalculationString { get { return _calculationString; } }

        #endregion

        #region Constructor

        /// <summary>
        /// Számológép eseményargumentum példányosítása.
        /// </summary>
        /// <param name="result">Eredmény.</param>
        /// <param name="calculationString">Számítás szövege.</param>
        public CalculatorEventArgs(double result, string calculationString)
        {
            _result = result;
            _calculationString = calculationString;
        }

        #endregion
    }
}
