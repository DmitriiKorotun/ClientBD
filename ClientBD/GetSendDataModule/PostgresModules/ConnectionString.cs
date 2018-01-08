using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.GetSendDataModule.PostgresModules
{
    class ConnectionString
    {
        //private static string Host = "Server=127.0.0.1";
        //private static string User = "postgres";
        //private static string DBname = "123";
        //private static string Password = "9370lambor";
        //private static string Port = "5432";

        string Host { get; set; }
        string User { get; set; }
        string DBname { get; set; }
        string Password { get; set; }
        string Port { get; set; }

        public string GetConnectionString()
        {
            Host = "127.0.0.1";
            User = "postgres";
            DBname = "Users";
            Password = "9370lambor";
            Port = "5432";

            return String.Format(
                "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};",
                Host,
                User,
                DBname,
                Port,
                Password);
        }
    }
}
