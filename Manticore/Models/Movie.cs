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
        // Setup an object/db ID
        [Key]
        public int Id { get; set; }

        // Ltes tell the system how to display this and what items should be available
        [DisplayName("Movie Title")]
        public string MovieName { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
    }
}
