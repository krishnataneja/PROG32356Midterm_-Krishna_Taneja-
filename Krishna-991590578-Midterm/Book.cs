using System;
using System.Collections.Generic;
using System.Text;

namespace Krishna_991590578_Midterm
{
    class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Title: " + Title + ", Genre: " + Genre + ", ISBN: " + ISBN;
        }
    }
}
