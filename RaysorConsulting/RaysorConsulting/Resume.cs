namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resume")]
    public partial class Resume
    {
        public Guid ResumeId { get; set; }

        public Guid ResumeOwnerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateUpdated { get; set; }

        [Column("Resume")]
        [Required]
        [MaxLength(250)]
        public byte[] Resume1 { get; set; }
    }
}
