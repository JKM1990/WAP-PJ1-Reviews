using System;
using DotNetEnv;

namespace projectOne.Models
{

    public class MyModel
    {

        private string CONNECTION_STRING;

        public MyModel()
        {
            Env.Load();
            CONNECTION_STRING = Env.GetString("CONNECTION_STRING");
        }

    }
}
