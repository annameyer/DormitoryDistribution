namespace DormitoryDistribution.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authorization")]
    public partial class Authorization
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Login { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsAdmin { get; set; }
    }
}
