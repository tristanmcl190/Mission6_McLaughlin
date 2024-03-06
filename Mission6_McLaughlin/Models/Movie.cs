using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_McLaughlin.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set;}
        public Category Category { get; set;}

        // Required with shatter this program dont know why and dont care why at this point. brute forcing requirments with html
        //[Required]
        public string? Title { get; set;}
        //[Required]
        public string? Year { get; set;}
        //[Required]
        public string? Director { get; set;}
        //[Required]
        public string? Rating { get; set;}
        public bool? Edited { get; set;}
        public string? LentTo { get; set; }
        public bool? CopiedToPlex { get; set;}
        public string? Notes { get; set; }
    }
}
