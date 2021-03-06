﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewTravelSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        public string ReviewerName { get; set; }

        public string ReviewTitle { get; set; }

        public DateTime ReviewDate { get; set; }

        public string ReviewContent { get; set; }

        public bool IsRecommended { get; set; }

        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        
    }
}