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
    }
}
