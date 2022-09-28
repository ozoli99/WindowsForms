using DocumentStatist.Model;

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

        }

        #endregion
    }
}