using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class UserRole
    {
        #region Fields

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRoleId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        #endregion Fields

        #region Relations

        public ICollection<UserPermission> UserPermissions { get; set; }

        #endregion Relations
    }
}