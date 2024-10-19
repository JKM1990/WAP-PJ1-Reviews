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

        private List<Review> _reviews;
        // private Review _reviewDetails;


        public Reviews()
        {

            // init
            _reviews = new List<Review>();

            Env.Load();
            CONNECTION_STRING = Env.GetString("CONNECTION_STRING");

            // construct required DB objects for use in private methods
            dbConnection = new MySqlConnection(CONNECTION_STRING);
            dbCommand = new MySqlCommand("", dbConnection);
        }

        public List<Review> reviews {
            get{
                return _reviews;
            }
          
        }

        public void setMeUp() {
            getReviewData();
        }
        private void getReviewData()
        {
            try{
                dbConnection.Open();
                dbCommand.CommandText = "SELECT * FROM reviews ORDER BY id DESC";
                dbReader = dbCommand.ExecuteReader();
                while (dbReader.Read())
                {

                    // testing write lines
                    Console.WriteLine("id: " + dbReader["id"].ToString());
                    Console.WriteLine("firstname: " + dbReader["first_name"].ToString());
                    Console.WriteLine("lastname: " + dbReader["last_name"].ToString());
                    Console.WriteLine("date: " + dbReader["date"].ToString());
                    Console.WriteLine("rating: " + dbReader["rating"].ToString());
                    Console.WriteLine("comment: " + dbReader["comment"].ToString());

                    Review review = new Review();
                    review.reviewID = Convert.ToInt32(dbReader["id"]);
                    review.firstName = dbReader["first_name"].ToString();
                    review.lastName = dbReader["last_name"].ToString();
                    review.reviewDate = Convert.ToDateTime(dbReader["date"]);
                    review.rating = Convert.ToInt32(dbReader["rating"]);
                    review.comment = dbReader["comment"].ToString();

                    _reviews.Add(review);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(">>> An error has occurred with getReviewData()");
                Console.WriteLine(">>> " + e.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddReview(Review review)
        {
            try
            {
                dbConnection.Open();
                dbCommand.CommandText = "INSERT INTO reviews (first_name, last_name, date, rating, comment) VALUES (@FirstName, @LastName, @Date, @Rating, @Comment)";
                dbCommand.Parameters.AddWithValue("@FirstName", review.firstName);
                dbCommand.Parameters.AddWithValue("@LastName", review.lastName);
                dbCommand.Parameters.AddWithValue("@Date", review.reviewDate);
                dbCommand.Parameters.AddWithValue("@Rating", review.rating);
                dbCommand.Parameters.AddWithValue("@Comment", review.comment);
                dbCommand.ExecuteNonQuery();
            }
            finally
            {
                dbConnection.Close();
            }

        }
        





    }
}
