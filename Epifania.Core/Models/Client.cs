using Epifania.Language;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class Client
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        #endregion Fields

        #region Relations

        public ICollection<Project> Projects { get; set; }

        #endregion Relations
    }
}