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

        #region Event handlers

        /// <summary>
        /// Ok gomb esemenykezeloje.
        /// </summary>
        private void ButtonOk_Click(object? sender, EventArgs e)
        {
            for (int i = _historyList.Count - 1; i >= 0; i--)
            {
                if (_historyList[i] >= _numericQuestionCount.Value || _checkedListBox.CheckedItems.Contains(_historyList[i]))
                    _historyList.RemoveAt(i);
            }
            while (_historyList.Count > _numericPeriodLength.Value)
                _historyList.RemoveAt(_historyList.Count - 1);

            DialogResult = DialogResult.OK;
            Close();
        }
        
        /// <summary>
        /// Megsem gomb esemenykezeloje.
        /// </summary>
        private void ButtonCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Tetel szamanak esemenykezeloje.
        /// </summary>
        private void NumericQuestionCount_ValueChanged(object? sender, EventArgs e)
        {
            if (_numericPeriodLength.Value > _numericQuestionCount.Value - 1)
                _numericPeriodLength.Value = _numericQuestionCount.Value - 1;
            _numericPeriodLength.Maximum = _numericQuestionCount.Value - 1;

            for (int i = _checkedListBox.Items.Count - 1; i >= _numericQuestionCount.Value; i--)
            {
                _checkedListBox.Items.Remove(_checkedListBox.Items[i]);
            }

            for (int i = _checkedListBox.Items.Count + 1; i <= _numericQuestionCount.Value; i++)
            {
                _checkedListBox.Items.Add(i, !_historyList.Contains(i));
            }
        }

        #endregion
    }
}
