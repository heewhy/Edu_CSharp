﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore_HHs
{
    class Novel : Book
    {
        public Novel(string name, string number, string price, string genre) : base(name, number, price, genre)
        {
            this.name = name;
            this.number = number;
            this.price = price;
            this.genre = genre;
        }
    }
}
