using Epifania.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class TeamUserEvaluation
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamUserEvaluationId { get; set; }

        #endregion Fields

        #region Relations

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        public ICollection<Evaluation> Evaluations { get; set; }

        #endregion Relations
    }
}