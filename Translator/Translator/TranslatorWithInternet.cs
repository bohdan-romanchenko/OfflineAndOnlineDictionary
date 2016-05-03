using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class TranslatorWithInternet : Form
    {
        public TranslatorWithInternet()
        {
            InitializeComponent();
        }

        private void buttonReplaceLanguages_Click(object sender, EventArgs e)
        {
            string tmp = languageFrom.Text;
            languageFrom.Text = languageTo.Text;
            languageTo.Text = tmp;
            textBoxResult.Text = "";
            textBoxSentence.Text = "";
        }

        private void languageFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string editedLanguage(string stringToCheck)
        {
            switch (stringToCheck)
            {
                case "English":
                    return "en";
                case "Українська":
                    return "uk";
                case "Русский":
                    return "ru";
                case "中国简体":
                    return "zh-CN";
                case "日本の":
                    return "ja";
                case "Français":
                    return "fr";
                case "Deutsch":
                    return "de";
                default:
                    return "en";
            }
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            if (textBoxSentence.Text.Equals(""))
            {
                MessageBox.Show("Error while translating! Inputted empty string.");
            }
            else if (languageFrom.Text.Equals("") || languageTo.Text.Equals(""))
            {
                MessageBox.Show("Error while translating! Language wasn't choosen");
            }
            else
            {
                string langFrom = editedLanguage(languageFrom.Text);
                string langTo = editedLanguage(languageTo.Text);
                textBoxResult.Text = GetTranslation.TranslateTextWithGoogle(
                    textBoxSentence.Text.Replace(".", " ").Trim(), langFrom + "|" + langTo);
            }
        }
    }
}
