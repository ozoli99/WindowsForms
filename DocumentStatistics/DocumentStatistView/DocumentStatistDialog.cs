using DocumentStatist.Model;
using static System.Windows.Forms.AxHost;

namespace DocumentStatistView
{
    public partial class DocumentStatistDialog : Form
    {
        #region Private fields

        DocumentStatistics? _documentStatistics;

        #endregion

        #region Constructor

        public DocumentStatistDialog()
        {
            InitializeComponent();

            openFileDialogMenuItem.Click += OpenDialog;
            countWordsMenuItem.Click += CountWords;
        }

        #endregion

        #region Event handlers

        private void OpenDialog(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _documentStatistics = new DocumentStatistics(openFileDialog.FileName);
                        _documentStatistics.Load();
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show("File reading is unsuccessful!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!String.IsNullOrEmpty(_documentStatistics.FileContent) && _documentStatistics.FileContent == textBox.Text)
                    {
                        return;
                    }

                    listBoxCounter.Items.Clear();
                    textBox.Text = _documentStatistics.FileContent;
                    UpdateLabels();
                }
            }
        }

        private void CountWords(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_documentStatistics.FileContent))
            {
                MessageBox.Show("There's no file content read.", "DocumentStatist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int minLength = Convert.ToInt32(spinBoxMinLength.Value);
            int minOccurence = Convert.ToInt32(spinBoxMinOccurence.Value);
            string ignoredWordsText = textBoxIgnoredWords.Text;
            List<string> ignoredWords = new List<string>();

            ignoredWords = ignoredWordsText
                .Split(',')
                .Select(w => w.Trim().ToLower())
                .ToList();

            _documentStatistics.Load();

            var pairs = _documentStatistics.DistinctWordCount
                .Where(p => p.Value >= minOccurence)
                .Where(p => p.Key.Length >= minLength)
                .Where(p => !ignoredWords.Contains(p.Key))
                .OrderByDescending(p => p.Value);

            listBoxCounter.Items.Clear();
            listBoxCounter.BeginUpdate();
            foreach (var pair in pairs)
            {
                listBoxCounter.Items.Add(pair.Key + ": " + pair.Value);
            }
            listBoxCounter.EndUpdate();

            UpdateLabels();
        }

        #endregion

        #region Private methods

        private void UpdateLabels()
        {
            labelCharacters.Text = "Character count: " + _documentStatistics.CharacterCount.ToString();
            labelNonWhitespaceCharacters.Text = "Non-whitespace characters: " + _documentStatistics.NonWhiteSpaceCharacterCount.ToString();
            labelSentences.Text = "Sentence count: " + _documentStatistics.SentenceCount.ToString();
            labelProperNouns.Text = "Proper noun count: " + _documentStatistics.ProperNounCount.ToString();
            labelColemanLieuIndex.Text = $"Coleman Lieu Index: {_documentStatistics.ColemanLieuIndex:f2}";
            labelFleschReadingEase.Text = $"Flesch Reading Ease: {_documentStatistics.FleschReadingEase:f2}";
        }

        #endregion
    }
}