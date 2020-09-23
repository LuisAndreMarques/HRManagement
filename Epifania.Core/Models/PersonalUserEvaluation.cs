using Epifania.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epifania.Core.Models
{
    public class PersonalUserEvaluation
    {
        #region Fields
                
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonalUserEvaluationId { get; set; }
        #endregion

        #region Relations

        public int UserId { get; set; }
                
        public ICollection<Evaluation> Evaluations { get; set; }

        public int FeedbackId { get; set; }

        public virtual Feedback Feedback { get; set; }
        #endregion Relations
    }
}
