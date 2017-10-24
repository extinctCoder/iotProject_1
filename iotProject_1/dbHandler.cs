﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace iotProject_1
{
    internal static class dbHandler
    {
        public static MySqlConnection getMySqlConnection()
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String mySqlConnectionString = "Server = " + MainWindow.getIpAddress().Trim() + "; Uid = " + MainWindow.getUid().Trim() + "; Pwd = " + MainWindow.getPassword().Trim() + "; port = 3306; database = iotproject_1";
                mySqlConnection = new MySqlConnection(mySqlConnectionString);
                MainWindow.setConsoleTXT("trying to open MySql connection");
                mySqlConnection.Open();
                MainWindow.setConsoleTXT("MySql Connection has opened");
            }
            catch (Exception ex)
            {
                MainWindow.setConsoleTXT(ex.Message.ToString());
                mySqlConnection = null;
            }
            return mySqlConnection;
        }
        public static void ledStateChanger(int id, int status)
        {
            MainWindow.setConsoleTXT("id -> " + id.ToString() + " status -> " + status.ToString());
            using (var tempMySqlConnection = dbHandler.getMySqlConnection())
            {
                if (tempMySqlConnection != null)
                {
                    MainWindow.setConsoleTXT("preparing MySql query command");
                    using (var tempMySqlCommand = tempMySqlConnection.CreateCommand())
                    {
                        tempMySqlCommand.CommandText =
                            "UPDATE `table_led` SET `status` = @status WHERE `table_led`.`id` = @id";
                        tempMySqlCommand.Parameters.AddWithValue("@status", status.ToString());
                        tempMySqlCommand.Parameters.AddWithValue("@id", id.ToString());
                        MainWindow.setConsoleTXT("MySql command -> UPDATE `table_led` SET `status` = " +
                                                 status.ToString() +
                                                 " WHERE `table_led`.`id` = " + id.ToString());
                        MainWindow.setConsoleTXT("injecting query command into MySql database");
                        try
                        {
                            tempMySqlCommand.ExecuteReader();
                            MainWindow.setConsoleTXT("MySql injection is successful");
                        }
                        catch (Exception ex)
                        {
                            MainWindow.setConsoleTXT(ex.Message.ToString());
                        }
                        finally
                        {
                            tempMySqlConnection.Close();
                            MainWindow.setConsoleTXT("MySql has been closed");
                        }
                    }
                }
            }
        }

    }
}
