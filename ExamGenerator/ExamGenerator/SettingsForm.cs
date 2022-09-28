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

        public SettingsForm()
        {
            InitializeComponent();
        }
    }
}
