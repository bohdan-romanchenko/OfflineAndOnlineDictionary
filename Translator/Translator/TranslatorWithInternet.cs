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
            tmp = textBoxResult.Text;
            textBoxResult.Text = textBoxSentence.Text;
            textBoxSentence.Text = tmp;
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
                MessageBox.Show("Помилка перекладу! Ви не ввели слово.");
            }
            else if (languageFrom.Text.Equals("") || languageTo.Text.Equals(""))
            {
                MessageBox.Show("Помилка перекладу! Ви не обрали мову");
            }
            else
            {
                string langFrom = editedLanguage(languageFrom.Text);
                string langTo = editedLanguage(languageTo.Text);
                textBoxResult.Text = GetTranslation.TranslateTextWithGoogle(
                    textBoxSentence.Text.Replace(".", " ").Trim(), langFrom + "|" + langTo);
                WorkWithDatabase database = new WorkWithDatabase();
                if (!database.dataExist(langFrom, textBoxSentence.Text) && !database.dataExist(langTo, textBoxResult.Text))
                    database.insertData(langFrom, textBoxSentence.Text, langTo, textBoxResult.Text);
                else if (!database.dataExist(langFrom, textBoxSentence.Text))
                {
                    int id = database.getIdByValue(langTo, textBoxResult.Text);
                    database.updateData(langFrom, textBoxSentence.Text, id);
                }
                else if (!database.dataExist(langTo, textBoxResult.Text))
                {
                    int id = database.getIdByValue(langFrom, textBoxSentence.Text);
                    database.updateData(langTo, textBoxResult.Text, id);
                }
                else
                    MessageBox.Show("Ці слова вже є в словнику");
            }
        }

        private void TranslatorWithInternet_Load(object sender, EventArgs e)
        {

        }
    }
}
