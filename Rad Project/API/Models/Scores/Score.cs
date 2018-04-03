using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Scores
{
    public class Score
    {
        [ForeignKey("Username")]
        public string UserName { get; set; }

        [Display(Name = "Score")]
        public int ScoreCount { get; set; }

        public virtual ApplicationUser Username { get; set; }
    }
}