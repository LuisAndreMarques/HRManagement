using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class UserPermission
    {
        #region Fields

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserPermissionId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        #endregion Fields

        #region Relations

        public int UserRoleId { get; set; }

        public UserRole UserRole { get; set; }

        #endregion Relations
    }
}