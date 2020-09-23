using Epifania.Common.Enums;
using Epifania.Language;
using Epifania.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class ObjectiveManagement
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ObjectiveManagementId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "DueDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DueDate { get; set; }

        #endregion Fields

        #region Relations

        public ObjectivesStatus ObjectivesStatus { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        #endregion Relations
    }
}