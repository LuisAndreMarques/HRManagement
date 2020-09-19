using Epifania.Language;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class Project
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Title")]
        [StringLength(50)]
        public string Title { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Description")]
        [StringLength(250)]
        public string Description { get; set; }

        #endregion Fields

        #region Relations

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
              
        public ICollection<Task> Tasks { get; set; }

        #endregion Relations
    }
}