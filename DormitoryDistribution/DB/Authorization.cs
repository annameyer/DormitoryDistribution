namespace DormitoryDistribution.DB
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Authorization")]
    public partial class Authorization
    {
        public int Id { get; set; }
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
