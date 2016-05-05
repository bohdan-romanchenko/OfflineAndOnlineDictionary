using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace Translator
{
    public partial class TranslatorWithoutInternet : Form
    {
        WorkWithDatabase workWithDatabase;
        public TranslatorWithoutInternet()
        {
            InitializeComponent();
            workWithDatabase = new WorkWithDatabase();
        }

        private void TranslatorWithoutInternet_Load(object sender, EventArgs e)
        {             
            if(workWithDatabase.isConnection())
                label1.Text = "Connected to database.";
            else
                label1.Text = "Failed to connect";
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

        private void buttonReplaceLanguages_Click(object sender, EventArgs e)
        {
            string tmp = languageFrom.Text;
            languageFrom.Text = languageTo.Text;
            languageTo.Text = tmp;
            tmp = textBoxResult.Text;
            textBoxResult.Text = textBoxSentence.Text;
            textBoxSentence.Text = tmp;
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
                string resultOfTranslating = workWithDatabase.getTranslation(editedLanguage(languageFrom.Text), textBoxSentence.Text, editedLanguage(languageTo.Text));
                if (!resultOfTranslating.Equals(""))
                    textBoxResult.Text = resultOfTranslating;
                else
                    textBoxResult.Text = "I'm sorry, but i can't translate this word :(";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWordManually addWordManually = new AddWordManually();
            addWordManually.Show();
        }

        private void languageFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOfAviableWords.Items.Clear();
            ArrayList allWordsByName = new ArrayList(workWithDatabase.getAllWordsByName(editedLanguage(languageFrom.Text)));
            for (int i = 0; i < allWordsByName.Count; i++)
            {
                if (!allWordsByName[i].Equals(""))
                {
                    comboBoxOfAviableWords.Items.Add(allWordsByName[i]);
                }
            }
        }

        private void comboBoxOfAviableWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSentence.Text = comboBoxOfAviableWords.Text;
        }
    }
}
