namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmailID { get; set; }

        public Guid UserID { get; set; }

        [Column("EmailAddress")]
        [Required]
        public string Email1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateEmailSent { get; set; }
    }
}
