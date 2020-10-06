using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Exercise
{
    public class Book
    {
        string title;
        string author;
        int category;
        int year;
        int pages;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        } 
        public int Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        } 
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }

        public Book()
        {             
            this.Pages =100;
            
        }

        public Book(int pages)
        {
            this.Pages = pages;
        }


    }
}
