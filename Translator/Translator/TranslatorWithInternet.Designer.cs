namespace Translator
{
    partial class TranslatorWithInternet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorWithInternet));
            this.buttonReplaceLanguages = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.languageTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSentence = new System.Windows.Forms.TextBox();
            this.languageFrom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonReplaceLanguages
            // 
            this.buttonReplaceLanguages.Location = new System.Drawing.Point(301, 14);
            this.buttonReplaceLanguages.Name = "buttonReplaceLanguages";
            this.buttonReplaceLanguages.Size = new System.Drawing.Size(56, 34);
            this.buttonReplaceLanguages.TabIndex = 16;
            this.buttonReplaceLanguages.Text = "<- | ->";
            this.buttonReplaceLanguages.UseVisualStyleBackColor = true;
            this.buttonReplaceLanguages.Click += new System.EventHandler(this.buttonReplaceLanguages_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(387, 55);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(260, 90);
            this.textBoxResult.TabIndex = 15;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(278, 70);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(103, 59);
            this.buttonTranslate.TabIndex = 14;
            this.buttonTranslate.Text = "ПЕРЕКЛАСТИ ->";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
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
            this.languageTo.Location = new System.Drawing.Point(497, 22);
            this.languageTo.Name = "languageTo";
            this.languageTo.Size = new System.Drawing.Size(150, 21);
            this.languageTo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Мова перекладу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Мова оригіналу";
            // 
            // textBoxSentence
            // 
            this.textBoxSentence.Location = new System.Drawing.Point(12, 55);
            this.textBoxSentence.Multiline = true;
            this.textBoxSentence.Name = "textBoxSentence";
            this.textBoxSentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSentence.Size = new System.Drawing.Size(260, 90);
            this.textBoxSentence.TabIndex = 10;
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
            this.languageFrom.Location = new System.Drawing.Point(108, 22);
            this.languageFrom.Name = "languageFrom";
            this.languageFrom.Size = new System.Drawing.Size(150, 21);
            this.languageFrom.TabIndex = 9;
            this.languageFrom.SelectedIndexChanged += new System.EventHandler(this.languageFrom_SelectedIndexChanged);
            // 
            // TranslatorWithInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 169);
            this.Controls.Add(this.buttonReplaceLanguages);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.languageTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSentence);
            this.Controls.Add(this.languageFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslatorWithInternet";
            this.Text = "Перекладач";
            this.Load += new System.EventHandler(this.TranslatorWithInternet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReplaceLanguages;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.ComboBox languageTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSentence;
        private System.Windows.Forms.ComboBox languageFrom;
    }
}