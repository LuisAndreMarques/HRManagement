using Epifania.Language;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class Company
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        #endregion Fields
    }
}