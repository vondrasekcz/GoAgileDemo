﻿using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GoAgile.Models
{
    public class CreateRetrospectiveViewModel
    {
        [Required]
        [Display(Name = "Retrospective Name")]
        [StringLength(maximumLength: 30)]
        public string RetrospectiveName { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string Project { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [StringLength(maximumLength: 255)]
        public string Comment { get; set; }
    }

    public class RetrospectiveViewModel : AsSerializeable
    {
        public string GuidId { get; set; }

        public string State { get; set; }

        public string Owner { get; set; }
    }

    public abstract class AsSerializeable
    {
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}