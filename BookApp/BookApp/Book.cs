﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
   public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public int Price { get; set; }
        //public override string ToString()
        //{
        //    return string.Format("{0} by {1} (Price: Rs{2})", Title, Author, Price);
        //}
    }
}
