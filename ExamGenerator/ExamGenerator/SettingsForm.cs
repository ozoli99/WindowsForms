using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace ExamGenerator
{
    /// <summary>
    /// Beallitasok kezeloablakanak tipusa.
    /// </summary>
    public partial class SettingsForm : Form
    {
        #region Private fields

        private List<int> _historyList;

        #endregion

        #region Properties

        /// <summary>
        /// Tetelek szamanak lekerdezese.
        /// </summary>
        public int QuestionCount
        { 
            get { return Convert.ToInt32(_numericQuestionCount.Value); }
        }

        /// <summary>
        /// Periodus hosszanak lekerdezese.
        /// </summary>
        public int PeriodLength
        { 
            get { return Convert.ToInt32(_numericPeriodLength.Value); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Beallitasok kezeloablakanak peldanyositasa.
        /// </summary>
        /// <param name="questionCount">Tetelek szama.</param>
        /// <param name="periodCount">Periodushossz.</param>
        /// <param name="historyList">Korabbi tetelek listaja.</param>
        public SettingsForm(int questionCount, int periodCount, List<int> historyList)
        {
            InitializeComponent();

            _numericQuestionCount.Value = questionCount;
            _numericPeriodLength.Value = periodCount;
            _historyList = historyList;

            for (int i = 1; i < _numericQuestionCount.Value; i++)
            {
                _checkedListBox.Items.Add(i, !_historyList.Contains(i));
            }

            _numericQuestionCount.ValueChanged += new EventHandler(NumericQuestionCount_ValueChanged);
        }

        #endregion
    }
}
