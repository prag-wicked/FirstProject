using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.UI.Models
{
    public class MockDB
    {
        public List<BookDetail> GetBooks()
        {
            List<BookDetail> ls = new List<BookDetail>();
            BookDetail bookDetails1 = new BookDetail();
            bookDetails1.ImageCover = "";
            bookDetails1.Author = "Raj";
            bookDetails1.Genre = "Fiction";
            bookDetails1.Name = "Five point someone";

            BookDetail bookDetails2 = new BookDetail();
            bookDetails2.ImageCover = "";
            bookDetails2.Author = "Nidhi";
            bookDetails2.Genre = "Horror";
            bookDetails2.Name = "Raat";

            BookDetail bookDetails3 = new BookDetail();
            bookDetails3.ImageCover = "Fiction";
            bookDetails3.Author = "Jack";
            bookDetails3.Genre = "Comedy";
            bookDetails3.Name = "Comedy Nights";

            BookDetail bookDetails4 = new BookDetail();
            bookDetails4.ImageCover = "Fantasy";
            bookDetails4.Author = "Jack1";
            bookDetails4.Genre = "Comedy1";
            bookDetails4.Name = "Comedy Nights";

            ls.Add(bookDetails1);
            ls.Add(bookDetails2);
            ls.Add(bookDetails3);
            ls.Add(bookDetails4);

            return ls;
        }

        public List<BookDetail> GetByName(string bookName)
        {
            List<BookDetail> allBooks = GetBooks();
            //BookDetail bookDetail = bookDetails.Where(x => x.Name.Equals(bookName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            List<BookDetail> bookMatchingName = allBooks.Where(x => x.Name.Equals(bookName, StringComparison.OrdinalIgnoreCase)).ToList();
            return bookMatchingName;            
        }
    }
}


