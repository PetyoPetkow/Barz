﻿namespace BarZ.Areas.Bar_reviews.Models.Bars.ViewModels
{
    using BarZ.Data.Models;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class BarViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("Work from")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime BeginningOfTheWorkDay { get; set; }


        [DisplayName("To")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime EndOfTheWorkDay { get; set; }


        [DisplayName("Review")]
        public string Description { get; set; }

        [DisplayName("Facebook page")]
        public string FacebookPageUrl { get; set; }

        public virtual Destination Destination { get; set; }
    }
}

