using Epifania.Language;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class Event
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "StartDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? StartDate { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "EndDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? EndDate { get; set; }

        #endregion Fields

        #region Relations

        public int EnventTypeId { get; set; }

        public virtual EventType EventType { get; set; }

        #endregion Relations
    }
}