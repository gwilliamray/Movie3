using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie3.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required (ErrorMessage ="The Name is required")]
        [Display (Name = "Title")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Please enter a year")]
        [Range(1889,2999,ErrorMessage ="Year must be after 1989")]
        public int? Year { get; set; }

        [Required (ErrorMessage ="You must enter a Rating")]
        [Range(1,6,ErrorMessage ="Rating must be between 1 and 5")]
        public int? Rating { get; set; }

        [Required(ErrorMessage ="Please enter a genre.")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
