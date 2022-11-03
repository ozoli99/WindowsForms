using DocumentStatist.Model;
using DocumentStatist.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DocumentStatistView
{
    public partial class DocumentStatistControl : UserControl
    {
        #region Private fields

        private IDocumentStatistics? _documentStatistics;

        #endregion
        
        #region Constructor

        public DocumentStatistControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Public methods

        public void LoadFile(IFileManager fileManager)
        {
            _documentStatistics = new DocumentStatistics(fileManager);
            _documentStatistics.Load();

            if (!String.IsNullOrEmpty(_documentStatistics.FileContent) && _documentStatistics.FileContent == textBox.Text)
                return;

            UpdateUI();
        }

        public void CalculateStatistics()
        {
            if (_documentStatistics == null || String.IsNullOrEmpty(_documentStatistics.FileContent))
            {
                MessageBox.Show("No file is loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int minLength = Convert.ToInt32(spinBoxMinLength.Value);
            int minOccurrence = Convert.ToInt32(spinBoxMinOccurrence.Value);

            var ignoredWords = textBoxIgnoredWords.Text.Split(',')
                .Select(w => w.Trim().ToLower())
                .ToList() ?? new List<string>();

            var pairs = _documentStatistics.DistinctWordCount
                .Where(p => p.Value >= minOccurrence)
                .Where(p => p.Key.Length >= minLength)
                .Where(p => !ignoredWords.Contains(p.Key))
                .OrderByDescending(p => p.Value);

            listBoxCounter.Items.Clear(); // ujboli statisztika keszitesekor toroljuk a mar a listan szerepl elemeket
            listBoxCounter.BeginUpdate();
            foreach (var pair in pairs)
            {
                listBoxCounter.Items.Add(pair.Key + ": " + pair.Value);
            }
            listBoxCounter.EndUpdate();
        }

        #endregion

        #region Private methods

        private void UpdateUI()
        {
            listBoxCounter.Items.Clear();
            textBox.Text = _documentStatistics.FileContent;

            labelCharacters.Text = labelCharacters.Text.Split(':')[0] + ": " + _documentStatistics!.CharacterCount;
            labelNonWhitespaceCharacters.Text = labelNonWhitespaceCharacters.Text.Split(':')[0] + ": " + _documentStatistics.NonWhiteSpaceCharacterCount;
            labelSentences.Text = labelSentences.Text.Split(':')[0] + ": " + _documentStatistics.SentenceCount;
            labelProperNouns.Text = labelProperNouns.Text.Split(':')[0] + ": " + _documentStatistics.ProperNounCount;
            labelColemanLieuIndex.Text = labelColemanLieuIndex.Text.Split(':')[0] + ": " + Math.Round(_documentStatistics.ColemanLieuIndex, 2);
            labelFleschReadingEase.Text = labelFleschReadingEase.Text.Split(':')[0] + ": " + Math.Round(_documentStatistics.FleschReadingEase, 2);
        }

        #endregion
    }
}
