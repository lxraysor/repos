namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OtherUser
    {
        public Guid OtherUserID { get; set; }

        public Guid? UserID { get; set; }

        public int? UserTypeID { get; set; }

        [StringLength(150)]
        public string UserFirstName { get; set; }

        [StringLength(150)]
        public string UserLastName { get; set; }

        public int? EmailId { get; set; }
    }
}
