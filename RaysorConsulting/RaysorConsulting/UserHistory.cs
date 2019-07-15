namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHistory")]
    public partial class UserHistory
    {
        public Guid ID { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        [MaxLength(50)]
        public byte[] UserHash { get; set; }

        [MaxLength(50)]
        public byte[] UserSalt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdateDate { get; set; }
    }
}
