using System.ComponentModel.DataAnnotations;

namespace NonprofitTracker.Models
{
    public class Program
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ICollection<ConstituentProgram> ConstituentPrograms { get; set; } = new List<ConstituentProgram>();

        [Display(Name = "Participant Count")]
        public int ParticipantCount => ConstituentPrograms.Count;
    }

    public class ConstituentProgram
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Constituent")]
        public int ConstituentId { get; set; }

        [Required]
        [Display(Name = "Program")]
        public int ProgramId { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; } = DateTime.Today;

        [Display(Name = "Completion Date")]
        public DateTime? CompletionDate { get; set; }

        [Display(Name = "Status")]
        public ProgramStatus Status { get; set; } = ProgramStatus.Active;

        [Display(Name = "Outcome Rating")]
        [Range(1, 5)]
        public int? OutcomeRating { get; set; }

        [Display(Name = "Satisfaction Rating")]
        [Range(1, 5)]
        public int? SatisfactionRating { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Constituent Constituent { get; set; } = null!;
        public virtual Program Program { get; set; } = null!;
    }

    public enum ProgramStatus
    {
        Active,
        Completed,
        Withdrawn,
        [Display(Name = "On Hold")]
        OnHold
    }
}
