namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserQualification
    {
        [Key]
        public Guid OwnerExperianceID { get; set; }

        public Guid ResumeOwnerID { get; set; }

        [StringLength(50)]
        public string QualificationItem { get; set; }

        [StringLength(100)]
        public string QualificationDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? QualificationStart { get; set; }

        public int? ExperianceYears { get; set; }
    }
}
