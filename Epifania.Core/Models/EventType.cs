using Epifania.Language;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class EventType
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventTypeId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "IsSingleEvent")]
        public bool IsSingleEvent { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "IsMultipleDayEvent")]
        public bool IsMultipleDayEvent { get; set; }

        #endregion Fields
    }
}