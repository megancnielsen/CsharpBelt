using System;
using System.ComponentModel.DataAnnotations;

namespace CsharpBelt.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Must be at least {1} characters")]

        public string Body { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int BandId { get; set; }
        public int UserId { get; set; }
        public User Author { get; set; }
        public Band Band { get; set; }
    }
}