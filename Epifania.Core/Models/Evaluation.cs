using Epifania.Language;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class Evaluation
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EvaluationId { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Display(ResourceType = typeof(EpifaniaResources), Name = "Percentage")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 100)]
        [Column(TypeName = "decimal(3,2)")]
        public decimal PercentageAcquired { get; set; }

        #endregion Fields
    }
}