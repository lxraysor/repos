namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmailType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmailID { get; set; }

        [Required]
        public string EmailDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateEmailed { get; set; }
    }
}
