using System;
using System.ComponentModel.DataAnnotations;

namespace WepApp_Movies_ModelFirst.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        //I parentesen vælger man kun at bruge Date og ikke Time
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}