namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResumeType")]
    public partial class ResumeType
    {
        public int ResumeTypeID { get; set; }

        [Column("ResumeType")]
        [StringLength(50)]
        public string ResumeType1 { get; set; }

        [StringLength(50)]
        public string ResumeTypeDesccription { get; set; }
    }
}
