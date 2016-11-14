using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Manticore.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Movie Title")]
        public string MovieName { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
    }
}