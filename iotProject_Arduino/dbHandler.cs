namespace iotProject_Arduino
{
    using System;

    using MySql.Data.MySqlClient;

    internal static class dbHandler
    {
        public static bool getLedState(int id)
        {
            bool tempFlag = true;
            using (var tempMySqlConnection = getMySqlConnection())
            {
                if (tempMySqlConnection != null)
                {
                    using (var tempMySqlCommand = tempMySqlConnection.CreateCommand())
                    {
                        tempMySqlCommand.CommandText =
                            "SELECT table_led.status FROM iotproject_1.table_led WHERE iotproject_1.table_led.id = @id";
                        tempMySqlCommand.Parameters.AddWithValue("@id", id.ToString());
                        try
                        {
                            using (MySqlDataReader tempDataReader = tempMySqlCommand.ExecuteReader())
                            {
                                while (tempDataReader.Read())
                                {
                                    tempFlag = (Convert.ToInt32(tempDataReader.GetString("status")) == 1)
                                                   ? true
                                                   : false;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MainWindow.setConsoleTXT(ex.Message.ToString());
                        }
                        finally
                        {
                            tempMySqlConnection.Close();
                        }
                    }
                }
            }

            return tempFlag;
        }

        public static MySqlConnection getMySqlConnection()
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                string mySqlConnectionString =
                    "Server = localhost; Uid = root; Pwd = ; port = 3306; database = iotproject_1";
                mySqlConnection = new MySqlConnection(mySqlConnectionString);
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MainWindow.setConsoleTXT(ex.Message.ToString());
                mySqlConnection = null;
            }

            return mySqlConnection;
        }
    }
}