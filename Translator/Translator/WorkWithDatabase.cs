using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Translator
{
    class WorkWithDatabase
    {
        private OleDbConnection connection = new OleDbConnection();

        public WorkWithDatabase()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Study\OOP\Coursach\Translator\Translator\Translator\dictionary.mdb;
                                                Persist Security Info=False;";
        }

        public bool isConnection()
        {
            bool returnValue;
            try
            {
                connection.Open();
                returnValue = true;
                connection.Close();
            }
            catch(Exception ex)
            {
                returnValue = false;
            }
            return returnValue;
        }

        public string getTranslation(string languageFrom, string word,string languageTo)
        {
            return getValueByID(languageTo, getIdByValue(languageFrom, word));
        }

        public int getIdByValue(string language, string word)
        {
            int returnValue = -1;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from dict where " + language + "='" + word+ "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //returnValue = Int32.Parse(reader[0].ToString());
                    returnValue = Int32.Parse(reader["id"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return returnValue;
        }

        public string getValueByID(string language, int id)
        {
            string returnString = "";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from dict where id=" + id + "";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    returnString = reader[language].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return returnString;
        }

        //not tested function yet
        public List<string> getAllWordsByName(string language)
        {
            List<string> returnList = new List<string>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select " + language + " from dict";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    returnList.Add(reader[0].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            returnList.Sort();
            return returnList;
        }

        public bool dataExist(string language, string word)
        {
            return getIdByValue(language, word) != -1;
        }

        public void insertData(string languageFrom, string wordFrom, string languageTo, string wordTo)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //not shure about value or values and breckets
                command.CommandText = "insert into dict (" + languageFrom + "," + languageTo + ") values('" + wordFrom + "','" + wordTo + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //not tested function yet
        public void updateData(string language, string word, long id)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update dict set " + language + "='" + word + "' where id=" + id;
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
