using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Exercise
{
    class ChildBook : Book
    {
        private static Book[] allBooks;

        public static Book[] GetChildBooks()
        {
            Book[] allChildBooks = new Book[0];
            int bookCounter = 0;

            foreach (Book book in allBooks)
            {
                if (book.Category == 1)
                {
                    Array.Resize(ref allChildBooks, bookCounter);
                    allChildBooks[bookCounter] = book;
                    bookCounter++;
                }
            }

            return allChildBooks;
        }
       
    }
}
