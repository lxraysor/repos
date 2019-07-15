namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserQuestion")]
    public partial class UserQuestion
    {
        [Key]
        public int QuestionID { get; set; }

        public Guid? UserID { get; set; }

        public string Question { get; set; }

        public int QuestionTypeID { get; set; }
    }
}
