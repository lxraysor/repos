namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserID { get; set; }

        public int? UserType { get; set; }

        public int? RoleID { get; set; }

        [StringLength(255)]
        public string UserHash { get; set; }

        [StringLength(255)]
        public string SaltHash { get; set; }

        public bool? Active { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateLastLogin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DatePasswordChanged { get; set; }
    }
}
