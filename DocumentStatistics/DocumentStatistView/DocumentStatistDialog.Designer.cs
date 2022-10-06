namespace DocumentStatistView
{
    partial class DocumentStatistDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countWordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBoxCounter = new System.Windows.Forms.ListBox();
            this.labelMinLength = new System.Windows.Forms.Label();
            this.labelMinOccurence = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCharacters = new System.Windows.Forms.Label();
            this.labelNonWhitespaceCharacters = new System.Windows.Forms.Label();
            this.labelSentences = new System.Windows.Forms.Label();
            this.labelProperNouns = new System.Windows.Forms.Label();
            this.labelColemanLieuIndex = new System.Windows.Forms.Label();
            this.labelFleschReadingEase = new System.Windows.Forms.Label();
            this.spinBoxMinLength = new System.Windows.Forms.NumericUpDown();
            this.spinBoxMinOccurence = new System.Windows.Forms.NumericUpDown();
            this.textBoxIgnoredWords = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinOccurence)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileDialogMenuItem,
            this.countWordsMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openFileDialogMenuItem
            // 
            this.openFileDialogMenuItem.Name = "openFileDialogMenuItem";
            this.openFileDialogMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openFileDialogMenuItem.Text = "Open file dialog";
            // 
            // countWordsMenuItem
            // 
            this.countWordsMenuItem.Name = "countWordsMenuItem";
            this.countWordsMenuItem.Size = new System.Drawing.Size(158, 22);
            this.countWordsMenuItem.Text = "Count words";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 38);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(380, 300);
            this.textBox.TabIndex = 1;
            // 
            // listBoxCounter
            // 
            this.listBoxCounter.FormattingEnabled = true;
            this.listBoxCounter.ItemHeight = 15;
            this.listBoxCounter.Location = new System.Drawing.Point(408, 38);
            this.listBoxCounter.Name = "listBoxCounter";
            this.listBoxCounter.Size = new System.Drawing.Size(380, 304);
            this.listBoxCounter.TabIndex = 2;
            // 
            // labelMinLength
            // 
            this.labelMinLength.AutoSize = true;
            this.labelMinLength.Location = new System.Drawing.Point(12, 352);
            this.labelMinLength.Name = "labelMinLength";
            this.labelMinLength.Size = new System.Drawing.Size(130, 15);
            this.labelMinLength.TabIndex = 3;
            this.labelMinLength.Text = "Minimum word length:";
            // 
            // labelMinOccurence
            // 
            this.labelMinOccurence.AutoSize = true;
            this.labelMinOccurence.Location = new System.Drawing.Point(12, 387);
            this.labelMinOccurence.Name = "labelMinOccurence";
            this.labelMinOccurence.Size = new System.Drawing.Size(151, 15);
            this.labelMinOccurence.TabIndex = 4;
            this.labelMinOccurence.Text = "Minimum word occurence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ignored words:";
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.Location = new System.Drawing.Point(408, 352);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(95, 15);
            this.labelCharacters.TabIndex = 6;
            this.labelCharacters.Text = "Character count:";
            // 
            // labelNonWhitespaceCharacters
            // 
            this.labelNonWhitespaceCharacters.AutoSize = true;
            this.labelNonWhitespaceCharacters.Location = new System.Drawing.Point(408, 387);
            this.labelNonWhitespaceCharacters.Name = "labelNonWhitespaceCharacters";
            this.labelNonWhitespaceCharacters.Size = new System.Drawing.Size(154, 15);
            this.labelNonWhitespaceCharacters.TabIndex = 7;
            this.labelNonWhitespaceCharacters.Text = "Non-whitespace characters:";
            // 
            // labelSentences
            // 
            this.labelSentences.AutoSize = true;
            this.labelSentences.Location = new System.Drawing.Point(408, 417);
            this.labelSentences.Name = "labelSentences";
            this.labelSentences.Size = new System.Drawing.Size(92, 15);
            this.labelSentences.TabIndex = 8;
            this.labelSentences.Text = "Sentence count:";
            // 
            // labelProperNouns
            // 
            this.labelProperNouns.AutoSize = true;
            this.labelProperNouns.Location = new System.Drawing.Point(635, 352);
            this.labelProperNouns.Name = "labelProperNouns";
            this.labelProperNouns.Size = new System.Drawing.Size(110, 15);
            this.labelProperNouns.TabIndex = 9;
            this.labelProperNouns.Text = "Proper noun count:";
            // 
            // labelColemanLieuIndex
            // 
            this.labelColemanLieuIndex.AutoSize = true;
            this.labelColemanLieuIndex.Location = new System.Drawing.Point(635, 387);
            this.labelColemanLieuIndex.Name = "labelColemanLieuIndex";
            this.labelColemanLieuIndex.Size = new System.Drawing.Size(115, 15);
            this.labelColemanLieuIndex.TabIndex = 10;
            this.labelColemanLieuIndex.Text = "Coleman Lieu Index:";
            // 
            // labelFleschReadingEase
            // 
            this.labelFleschReadingEase.AutoSize = true;
            this.labelFleschReadingEase.Location = new System.Drawing.Point(635, 417);
            this.labelFleschReadingEase.Name = "labelFleschReadingEase";
            this.labelFleschReadingEase.Size = new System.Drawing.Size(115, 15);
            this.labelFleschReadingEase.TabIndex = 11;
            this.labelFleschReadingEase.Text = "Flesch Reading Ease:";
            // 
            // spinBoxMinLength
            // 
            this.spinBoxMinLength.Location = new System.Drawing.Point(169, 350);
            this.spinBoxMinLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinBoxMinLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxMinLength.Name = "spinBoxMinLength";
            this.spinBoxMinLength.Size = new System.Drawing.Size(131, 23);
            this.spinBoxMinLength.TabIndex = 12;
            this.spinBoxMinLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spinBoxMinOccurence
            // 
            this.spinBoxMinOccurence.Location = new System.Drawing.Point(169, 385);
            this.spinBoxMinOccurence.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinBoxMinOccurence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxMinOccurence.Name = "spinBoxMinOccurence";
            this.spinBoxMinOccurence.Size = new System.Drawing.Size(131, 23);
            this.spinBoxMinOccurence.TabIndex = 13;
            this.spinBoxMinOccurence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxIgnoredWords
            // 
            this.textBoxIgnoredWords.Location = new System.Drawing.Point(104, 414);
            this.textBoxIgnoredWords.Name = "textBoxIgnoredWords";
            this.textBoxIgnoredWords.Size = new System.Drawing.Size(196, 23);
            this.textBoxIgnoredWords.TabIndex = 14;
            // 
            // DocumentStatistDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIgnoredWords);
            this.Controls.Add(this.spinBoxMinOccurence);
            this.Controls.Add(this.spinBoxMinLength);
            this.Controls.Add(this.labelFleschReadingEase);
            this.Controls.Add(this.labelColemanLieuIndex);
            this.Controls.Add(this.labelProperNouns);
            this.Controls.Add(this.labelSentences);
            this.Controls.Add(this.labelNonWhitespaceCharacters);
            this.Controls.Add(this.labelCharacters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMinOccurence);
            this.Controls.Add(this.labelMinLength);
            this.Controls.Add(this.listBoxCounter);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DocumentStatistDialog";
            this.Text = "Document Statistics";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinOccurence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem openFileDialogMenuItem;
        private ToolStripMenuItem countWordsMenuItem;
        private TextBox textBox;
        private ListBox listBoxCounter;
        private Label labelMinLength;
        private Label labelMinOccurence;
        private Label label3;
        private Label labelCharacters;
        private Label labelNonWhitespaceCharacters;
        private Label labelSentences;
        private Label labelProperNouns;
        private Label labelColemanLieuIndex;
        private Label labelFleschReadingEase;
        private NumericUpDown spinBoxMinLength;
        private NumericUpDown spinBoxMinOccurence;
        private TextBox textBoxIgnoredWords;
    }
}