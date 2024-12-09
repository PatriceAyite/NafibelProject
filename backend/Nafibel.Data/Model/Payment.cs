﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{

    public class Payment 
    {
        [Key]
        public Ulid Id { get; set; }

     

        [Required]
        public Ulid? HaircutId { get; set; }

        public Haircut? Haircut { get; set; }

        [Required]
        [Range(0, Double.MaxValue)]
        public double Amount { get; set; }

        [Required]
        [Unicode(true)]
        [MaxLength(255)]
        public string ClientName { get; set; } = string.Empty;

        public Ulid? ClientId { get; set; }

        [Required]
        public PaymentTypeEnum PaymentType { get; set; }


        [Required]
        public string CreatedBy { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedOn { get; set; }

        public string? ExternalId { get; set; }

        public string? ExternalPayload { get; set; } 

    }

    public enum PaymentTypeEnum
    {
        Advance,
        FullPayment
    }

}