using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.GetSendDataModule.PostgresModules
{
    class Postgres
    {
        bool Connect(out NpgsqlConnection connection)
        {
            try
            {
                connection = new NpgsqlConnection(new ConnectionString().GetConnectionString());
                Console.Out.WriteLine("Opening connection");
                connection.Open();
                return true;
            }
            catch (ArgumentException e)
            {
                connection = null;
                return false;
            }
        }

        bool CloseConnection(NpgsqlConnection connection)
        {
            connection.Close();
            return true;
        }

        public string Read(string commandText)
        {
            var connection = new NpgsqlConnection();
            Connect(out connection);
            var command = connection.CreateCommand();
            command.CommandText = commandText;

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(
                //    string.Format(
                //        "Reading from table=({0}, {1}, {2})",
                //        reader.GetInt32(0).ToString(),
                //        reader.GetString(1),
                //        reader.GetInt32(2).ToString()
                //        )
                //    );
            }

            CloseConnection(connection);
            return "";
        }
    }
}
