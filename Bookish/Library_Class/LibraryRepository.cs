using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace Library_Class
{
    public class LibraryRespository
    {
        private string connectionstring = @"Server=localhost;Database=bookish;Trusted_Connection=True;";

        public IEnumerable<Book> GetAllBooks()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            return connection.Query<Book>("SELECT * FROM dbo.books");
        }
    }
}
