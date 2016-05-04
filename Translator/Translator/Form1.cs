using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function checking for internet connection on PC
        /// </summary>
        /// <returns>True if connection is aviable and false if not aviable</returns>
        public bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                    using (var stream = client.OpenRead("http://www.google.com"))
                        return true;
            }
            catch
            {
                return false;
            }
        }

        public bool showDialogFormTiAccessInternetConnection()
        {
            // Create a new instance of the form.
            EnableAccessToInternet form1 = new EnableAccessToInternet();
            // Display the form as a modal dialog box.
            form1.ShowDialog();
            return form1.DialogResult == DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if internet connection is aviable show MessageBox where user decides to give internet coonection
            //for application, or not
            if (CheckForInternetConnection() && showDialogFormTiAccessInternetConnection())
            {
                //if everything is ok than use google translate api
                TranslatorWithInternet translatorWithInternet = new TranslatorWithInternet();
                translatorWithInternet.Show();
            }
            else
            {
                //else use custom database with dictionary
                TranslatorWithoutInternet translatorWithoutInternet = new TranslatorWithoutInternet();
                translatorWithoutInternet.Show();
            }
            
        }

    }
}
