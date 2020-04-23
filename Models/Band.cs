using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CsharpBelt.Models
{
    public class Band
    {
        [Key]
        public int BandId { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = " Must be at least {1} characters!")]
        public string Name { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = " Must be at least {1} characters!")]
        public string Genre { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = " Must be at least {1} characters!")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        
        // Navigation Property
        public User SubittedBy { get; set; }
        public List<Review> Reviews { get; set; }
    }
}