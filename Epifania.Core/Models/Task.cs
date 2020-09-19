using Epifania.Language;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Epifania.Core.Models
{
    public class Task
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "StartDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "EndDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "DueDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DueDate { get; set; }

        public TaskStatus TaskStatus { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Priority")]
        public int Priority { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Complexity")]
        public int Complexity { get; set; }

        #endregion Fields

        #region Relations

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        #endregion Relations
    }
}