using Epifania.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Epifania.Language;
namespace Epifania.Models
{
    public class User
    {
        #region Fields
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name ="UserName")]
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(200)]
        public string LastName { get; set; }
        [EmailAddress]
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(25)]
        public string NIF { get; set; }

        #endregion Fields

        #region Relations
        
        public int UserRoleId { get; set; }
        public virtual UserRole UserRole { get; set; }

        #endregion Relations
    }
}