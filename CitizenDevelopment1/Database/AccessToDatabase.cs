using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;

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

        public static void UpdateUser(int idConverted, User user)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                cnn.Execute($"update Users set applicationName=@applicationName, userName=@userName, comment=@comment where id={idConverted}", user);
                cnn.Close();
            }
        }

        public static void DeleteUser(int idConverted)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                cnn.Execute($"delete from Users where id={idConverted}");
                cnn.Close();
            }
        }

        private static string LoadConnectionString(string id = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
