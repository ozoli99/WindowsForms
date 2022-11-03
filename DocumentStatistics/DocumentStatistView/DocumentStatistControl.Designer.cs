namespace DocumentStatistView
{
    partial class DocumentStatistControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBoxCounter = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCharacters = new System.Windows.Forms.Label();
            this.labelProperNouns = new System.Windows.Forms.Label();
            this.labelColemanLieuIndex = new System.Windows.Forms.Label();
            this.labelFleschReadingEase = new System.Windows.Forms.Label();
            this.spinBoxMinLength = new System.Windows.Forms.NumericUpDown();
            this.spinBoxMinOccurrence = new System.Windows.Forms.NumericUpDown();
            this.textBoxIgnoredWords = new System.Windows.Forms.TextBox();
            this.labelNonWhitespaceCharacters = new System.Windows.Forms.Label();
            this.labelSentences = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinOccurrence)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 27);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(389, 289);
            this.textBox.TabIndex = 1;
            // 
            // listBoxCounter
            // 
            this.listBoxCounter.FormattingEnabled = true;
            this.listBoxCounter.ItemHeight = 15;
            this.listBoxCounter.Location = new System.Drawing.Point(407, 27);
            this.listBoxCounter.Name = "listBoxCounter";
            this.listBoxCounter.Size = new System.Drawing.Size(381, 289);
            this.listBoxCounter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum word length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum word occurrence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ignored words:";
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.Location = new System.Drawing.Point(407, 335);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(95, 15);
            this.labelCharacters.TabIndex = 6;
            this.labelCharacters.Text = "Character count:";
            // 
            // labelProperNouns
            // 
            this.labelProperNouns.AutoSize = true;
            this.labelProperNouns.Location = new System.Drawing.Point(620, 335);
            this.labelProperNouns.Name = "labelProperNouns";
            this.labelProperNouns.Size = new System.Drawing.Size(110, 15);
            this.labelProperNouns.TabIndex = 7;
            this.labelProperNouns.Text = "Proper noun count:";
            // 
            // labelColemanLieuIndex
            // 
            this.labelColemanLieuIndex.AutoSize = true;
            this.labelColemanLieuIndex.Location = new System.Drawing.Point(620, 374);
            this.labelColemanLieuIndex.Name = "labelColemanLieuIndex";
            this.labelColemanLieuIndex.Size = new System.Drawing.Size(115, 15);
            this.labelColemanLieuIndex.TabIndex = 8;
            this.labelColemanLieuIndex.Text = "Coleman Lieu Index:";
            // 
            // labelFleschReadingEase
            // 
            this.labelFleschReadingEase.AutoSize = true;
            this.labelFleschReadingEase.Location = new System.Drawing.Point(620, 413);
            this.labelFleschReadingEase.Name = "labelFleschReadingEase";
            this.labelFleschReadingEase.Size = new System.Drawing.Size(115, 15);
            this.labelFleschReadingEase.TabIndex = 9;
            this.labelFleschReadingEase.Text = "Flesch Reading Ease:";
            // 
            // spinBoxMinLength
            // 
            this.spinBoxMinLength.Location = new System.Drawing.Point(168, 333);
            this.spinBoxMinLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxMinLength.Name = "spinBoxMinLength";
            this.spinBoxMinLength.Size = new System.Drawing.Size(120, 23);
            this.spinBoxMinLength.TabIndex = 10;
            this.spinBoxMinLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spinBoxMinOccurrence
            // 
            this.spinBoxMinOccurrence.Location = new System.Drawing.Point(168, 372);
            this.spinBoxMinOccurrence.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinBoxMinOccurrence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxMinOccurrence.Name = "spinBoxMinOccurrence";
            this.spinBoxMinOccurrence.Size = new System.Drawing.Size(120, 23);
            this.spinBoxMinOccurrence.TabIndex = 11;
            this.spinBoxMinOccurrence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxIgnoredWords
            // 
            this.textBoxIgnoredWords.Location = new System.Drawing.Point(104, 410);
            this.textBoxIgnoredWords.Name = "textBoxIgnoredWords";
            this.textBoxIgnoredWords.Size = new System.Drawing.Size(184, 23);
            this.textBoxIgnoredWords.TabIndex = 12;
            // 
            // labelNonWhitespaceCharacters
            // 
            this.labelNonWhitespaceCharacters.AutoSize = true;
            this.labelNonWhitespaceCharacters.Location = new System.Drawing.Point(407, 374);
            this.labelNonWhitespaceCharacters.Name = "labelNonWhitespaceCharacters";
            this.labelNonWhitespaceCharacters.Size = new System.Drawing.Size(154, 15);
            this.labelNonWhitespaceCharacters.TabIndex = 13;
            this.labelNonWhitespaceCharacters.Text = "Non-whitespace characters:";
            // 
            // labelSentences
            // 
            this.labelSentences.AutoSize = true;
            this.labelSentences.Location = new System.Drawing.Point(407, 413);
            this.labelSentences.Name = "labelSentences";
            this.labelSentences.Size = new System.Drawing.Size(92, 15);
            this.labelSentences.TabIndex = 14;
            this.labelSentences.Text = "Sentence count:";
            // 
            // DocuStatDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSentences);
            this.Controls.Add(this.labelNonWhitespaceCharacters);
            this.Controls.Add(this.textBoxIgnoredWords);
            this.Controls.Add(this.spinBoxMinOccurrence);
            this.Controls.Add(this.spinBoxMinLength);
            this.Controls.Add(this.labelFleschReadingEase);
            this.Controls.Add(this.labelColemanLieuIndex);
            this.Controls.Add(this.labelProperNouns);
            this.Controls.Add(this.labelCharacters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCounter);
            this.Controls.Add(this.textBox);
            this.Name = "DocuStatDialog";
            this.Text = "Document statistics";
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxMinOccurrence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private ListBox listBoxCounter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelCharacters;
        private Label labelProperNouns;
        private Label labelColemanLieuIndex;
        private Label labelFleschReadingEase;
        private NumericUpDown spinBoxMinLength;
        private NumericUpDown spinBoxMinOccurrence;
        private TextBox textBoxIgnoredWords;
        private Label labelNonWhitespaceCharacters;
        private Label labelSentences;
    }
}
