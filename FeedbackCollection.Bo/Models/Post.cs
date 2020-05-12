using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FeedbackCollection.Bo.Models
{
    public class Post : BaseClass
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
