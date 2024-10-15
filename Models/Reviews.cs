using System;
using DotNetEnv;

namespace projectOne.Models
{

    public class Reviews
    {

        private string CONNECTION_STRING;

        public Reviews()
        {
            Env.Load();
            CONNECTION_STRING = Env.GetString("CONNECTION_STRING");
        }

    }
}
