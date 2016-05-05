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
    public partial class AddWordManually : Form
    {
        public AddWordManually()
        {
            InitializeComponent();
            WorkWithDatabase database = new WorkWithDatabase();
        }

        private void AddWordManually_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string langFrom = editedLanguage(languageFrom.Text);
            string langTo = editedLanguage(languageTo.Text);
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
                MessageBox.Show("All data already exist");
            MessageBox.Show("Dictionary updated");
        }
    }
}
