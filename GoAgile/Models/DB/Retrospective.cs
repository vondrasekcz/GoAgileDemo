﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GoAgile.Models.DB
{
    public class Retrospective
    {        
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Owner { get; set; }

        [Required]       
        [StringLength(255)]
        public string RetrospectiveName { get; set; }

        [Required]
        [StringLength(255)]
        public string Project { get; set; }

        [Required]        
        public DateTime StartDate { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public EventState State { get; set; }
    }
}