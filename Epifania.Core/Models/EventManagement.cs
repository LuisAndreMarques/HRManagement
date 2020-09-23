using Epifania.Common.Enums;
using Epifania.Language;
using Epifania.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class EventManagement
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventManagementId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Description")]
        [StringLength(250)]
        public string Description { get; set; }

        public EventManagementStatus EventManagementStatus { get; set; }

        #endregion Fields

        #region Relations

        public ObjectivesStatus ObjectivesStatus { get; set; }

        public int? UserRequiredId { get; set; }
        public virtual User UserRequired { get; set; }
        public int UserRequestedId { get; set; }
        public virtual User UserRequested { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        #endregion Relations
    }
}