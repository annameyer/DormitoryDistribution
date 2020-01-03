namespace DormitoryDistribution.DB
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Users")]
    public partial class Users
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Login { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
