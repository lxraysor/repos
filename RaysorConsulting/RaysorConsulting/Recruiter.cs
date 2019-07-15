namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recruiter")]
    public partial class Recruiter
    {
        public Guid RecruiterID { get; set; }

        public Guid? UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string RecruiterEmail { get; set; }

        [StringLength(50)]
        public string RecruiterFirstName { get; set; }

        [StringLength(50)]
        public string RecruiterLastName { get; set; }

        [StringLength(20)]
        public string RecruiterPhoneNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegistrationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmailUpdated { get; set; }
    }
}
