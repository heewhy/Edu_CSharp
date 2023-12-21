using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore_HHs
{
    class Book
    {
        public string name;
        public string number;
        public string price;
        public string genre;

        public Book(string name, string number, string price, string genre)
        {
            this.name = name;
            this.number = number;
            this.price = price;
            this.genre = genre;
        }
    }
}
