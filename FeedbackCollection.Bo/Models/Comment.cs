using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FeedbackCollection.Bo.Models
{
    public class Comment : BaseClass
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public virtual Post Post { get; set; }
    }
}
