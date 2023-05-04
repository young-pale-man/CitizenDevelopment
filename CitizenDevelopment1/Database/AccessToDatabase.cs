using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;
using CitizenDevelopment1.Views;

namespace CitizenDevelopment1.Database
{
    public class AccessToDatabase
    {
        public static void SaveUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (applicationName, userName, comment) values (@applicationName, @userName, @comment)", user);
            }
        }

        public static bool UpdateUser(int idConverted, User user)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                bool isRecordExists = IsIdExists(idConverted);
                if (isRecordExists)
                {
                    cnn.Open();
                    cnn.Execute($"update Users set applicationName=@applicationName, userName=@userName, comment=@comment where id={idConverted}", user);
                    cnn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool DeleteUser(int idConverted)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                bool isRecordExists = IsIdExists(idConverted);
                if (isRecordExists)
                {
                    cnn.Open();
                    cnn.Execute($"delete from Users where id={idConverted}");
                    cnn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static List<UsersOutput> DatabaseUser()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                List<UsersOutput> users = new List<UsersOutput>();

                cnn.Open();

                cmd.CommandText = "select * from Users";
                cmd.Connection = cnn;

                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new UsersOutput(
                        dr["id"].ToString(),
                        dr["applicationName"].ToString(),
                        dr["userName"].ToString(),
                        dr["comment"].ToString()
                        ));
                 }
                cnn.Close();
                return users;
            }
        }

        private static string LoadConnectionString(string id = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static bool IsIdExists(int idConverted)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                bool exists = false;
                try
                {
                    exists = cnn.ExecuteScalar<bool>($"SELECT EXISTS(SELECT 1 FROM Users WHERE id={idConverted})");
                }
                catch (Exception)
                {
                    exists = false;
                }
                return exists;
            }
        }
    }
}
