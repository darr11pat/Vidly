using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]

        public String Name { get; set; }

        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }

        public DateTime Releasedate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public DateTime Dateadded { get; set; }
    }
}