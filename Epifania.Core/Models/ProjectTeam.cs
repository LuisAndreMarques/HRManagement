using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class ProjectTeam
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectTeamId { get; set; }

        #endregion Fields

        #region Relations

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

        #endregion Relations
    }
}