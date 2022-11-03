using DocumentStatist.Model;
using DocumentStatist.Persistence;

namespace DocumentStatistView
{
    public partial class DocumentStatistDialog : Form
    {
        #region Private fields

        private IDocumentStatistics? _documentStatistics;

        #endregion

        #region Constructor

        public DocumentStatistDialog()
        {
            InitializeComponent();

            openFileDialogMenuItem.Click += OpenDialog;
            countWordsMenuItem.Click += CalculateStatistics;
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
                    IFileManager? fileManager = FileManagerFactory.CreateForPath(openFileDialog.FileName);

                    if (fileManager == null)
                    {
                        MessageBox.Show("File reading is unsuccessful!\nUnsupported file format.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        _documentStatistics = new DocumentStatistics(fileManager);
                        _documentStatistics.Load();
                    }
                    catch (FileManagerException ex)
                    {
                        MessageBox.Show("File reading is unsuccessful!\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!String.IsNullOrEmpty(_documentStatistics.FileContent)
                        && _documentStatistics.FileContent == textBox.Text)
                        return;

                    listBoxCounter.Items.Clear();
                    textBox.Text = _documentStatistics.FileContent;
                    UpdateLabels();
                }
            }
        }

        private void CalculateStatistics(object? sender, EventArgs e)
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

        private void UpdateLabels()
        {
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