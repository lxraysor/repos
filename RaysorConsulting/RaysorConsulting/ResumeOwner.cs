namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResumeOwner")]
    public partial class ResumeOwner
    {
        public Guid ResumeOwnerID { get; set; }

        public Guid? UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminEmail { get; set; }

        [Required]
        public string HashName { get; set; }

        [Required]
        public byte[] Salt { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateUpdated { get; set; }
    }
}
