using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Text;

namespace EFCore02.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }
        [MaxLength(150), Required]
        public string FullName { get; set; } = null!;
        [MaxLength(200),Required]
        public string Email { get; set; } = null!;
        [MaxLength(150), Required]
        public string Street { get; set; } = null!;
        [MaxLength(100), Required]
        public string City { get; set; } = null!;
        [MaxLength(100), Required]
        public string Country { get; set; } = null!;
        [MaxLength(20), Required,Column("ZipCode")]
        public string PostalCode { get; set; } = null!;
        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {Country}, {PostalCode}";

        #region Relations
        public Badge? Badge { get; set; }

        #endregion
    }
}
