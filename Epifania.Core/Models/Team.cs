using Epifania.Language;
using Epifania.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class Team
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        #endregion Fields

        #region Realtions

       

        public ICollection<User> Users { get; set; }

        #endregion Realtions
    }
}