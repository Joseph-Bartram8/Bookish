using System;
using System.Data.SqlClient;
using Dapper;

namespace BookRespository
{
    public class BookRepository
    {
        private string connectionString = @"Server=localhost;Database=bookish;Trusted_Connection=True;";

        public IEquatable<Book> GetAllBooks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<book>("SELECT * FROM books");
        }
    }
}
