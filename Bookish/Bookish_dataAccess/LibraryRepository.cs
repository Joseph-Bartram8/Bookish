using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Bookish_dataAccess
{
    public class LibraryRepository
    {
        private string connectionString = @"Server=localhost;Database=bookish;Trusted_Connection=True;";

        public IEnumerable<Book> GetAllBooks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>("SELECT * FROM dbo.Books");
        }

        public IEnumerable<Book> SearchBooks(string Search)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>("SELECT * FROM Books WHERE Title CONTAINS {Search} OR Author CONTAINS {Search}");
        }

        public Book GetBook(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            var book = connection.Query<Book>("SELECT * FROM dbo.Books WHERE Id = @id", new {id});
            return (Book)book;
        }

        public IEnumerable<Book> GetCopiesBorrowedByUser(string User)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>("SELECT * FROM Copies WHERE User = {User}");
        }
    }
}
