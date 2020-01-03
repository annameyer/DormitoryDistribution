namespace DormitoryDistribution.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hostel")]
    public partial class Hostel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(6)]
        public string Group { get; set; }

        public double? AverageMark { get; set; }

        public bool Activities { get; set; }

        public decimal? Income { get; set; }
    }
}
