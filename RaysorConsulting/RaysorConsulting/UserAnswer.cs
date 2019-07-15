namespace RaysorConsulting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAnswer
    {
        [Key]
        [Column(Order = 0)]
        public int AnswerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionID { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Answer { get; set; }
    }
}
