using DefineLabs_LibAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DefineLabs_LibAPI.DAL
{
    public class BookDL : IBook
    {
        string con = ConfigurationManager.ConnectionStrings["DefineLabs"].ConnectionString.ToString();
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>();

            try
            {
                //List<Author> authors = new List<Author>();
                using (SqlConnection conn = new SqlConnection(con))
                {
                    using (SqlCommand cmd = new SqlCommand("GETBookList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            books.Add(new Book
                            {
                                bookID = Convert.ToInt32(reader["AuthorID"]),
                                bookTitle = (reader["FirstName"]).ToString(),
                                authorID = Convert.ToInt32(reader["AuthorID"])

                            });

                        }

                    }
                }
            }
            catch (Exception e)
            {

            }
            return books;
        }

        public bool AddBook()
        {
            bool IsAdded = false;
            try
            {
                //List<Author> authors = new List<Author>();
                using (SqlConnection conn = new SqlConnection(con))
                {
                    using (SqlCommand cmd = new SqlCommand("GETBookList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        

                    }
                }
            }
            catch (Exception e)
            {

            }
            return IsAdded;
        } 

        public bool DeleteBook(int id)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteAuthorByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@authorID", id);
                        conn.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            IsDeleted = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            return IsDeleted;
        }

        public bool UpdateBook(int id)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    using (SqlCommand cmd = new SqlCommand("EditAuthorByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@authorID", id);
                        conn.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            IsUpdated = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }

            return IsUpdated;
        }
    }
}