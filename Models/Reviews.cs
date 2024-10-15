using System;
using MySqlConnector;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using DotNetEnv;


namespace projectOne.Models
{

    public class Reviews
    {

        private string CONNECTION_STRING;

        // db connectivity variables
        private MySqlConnection dbConnection;
        private MySqlCommand dbCommand;
        private MySqlDataReader dbReader;

        // property variables
        


        public Reviews()
        {
            Env.Load();
            CONNECTION_STRING = Env.GetString("CONNECTION_STRING");

            // construct required DB objects for use in private methods
            dbConnection = new MySqlConnection(CONNECTION_STRING);
            dbCommand = new MySqlCommand("", dbConnection);
        }

    }
}
