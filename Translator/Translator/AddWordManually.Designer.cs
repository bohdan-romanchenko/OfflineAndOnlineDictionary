namespace Translator
{
    partial class AddWordManually
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWordManually));
            this.languageTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.languageFrom = new System.Windows.Forms.ComboBox();
            this.textBoxSentence = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageTo
            // 
            this.languageTo.FormattingEnabled = true;
            this.languageTo.Items.AddRange(new object[] {
            "English",
            "Українська",
            "Русский",
            "Français",
            "Deutsch",
            "日本の"});
            this.languageTo.Location = new System.Drawing.Point(409, 12);
            this.languageTo.Name = "languageTo";
            this.languageTo.Size = new System.Drawing.Size(150, 21);
            this.languageTo.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Мова перекладу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Мова оригіналу";
            // 
            // languageFrom
            // 
            this.languageFrom.FormattingEnabled = true;
            this.languageFrom.Items.AddRange(new object[] {
            "English",
            "Українська",
            "Русский",
            "Français",
            "Deutsch",
            "日本の"});
            this.languageFrom.Location = new System.Drawing.Point(104, 12);
            this.languageFrom.Name = "languageFrom";
            this.languageFrom.Size = new System.Drawing.Size(150, 21);
            this.languageFrom.TabIndex = 25;
            // 
            // textBoxSentence
            // 
            this.textBoxSentence.Location = new System.Drawing.Point(8, 39);
            this.textBoxSentence.Multiline = true;
            this.textBoxSentence.Name = "textBoxSentence";
            this.textBoxSentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSentence.Size = new System.Drawing.Size(246, 90);
            this.textBoxSentence.TabIndex = 29;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(299, 39);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(260, 90);
            this.textBoxResult.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddWordManually
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSentence);
            this.Controls.Add(this.languageTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.languageFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWordManually";
            this.Text = "Додати слово";
            this.Load += new System.EventHandler(this.AddWordManually_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languageTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox languageFrom;
        private System.Windows.Forms.TextBox textBoxSentence;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button1;
    }
}