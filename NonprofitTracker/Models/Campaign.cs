using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NonprofitTracker.Extensions;

namespace NonprofitTracker.Models
{
    public class Campaign
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Goal Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal GoalAmount { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ICollection<Donation> Donations { get; set; } = new List<Donation>();

        [Display(Name = "Total Raised")]
        public decimal TotalRaised => Donations.SafeSum(d => d.Amount);

        [Display(Name = "Progress Percentage")]
        public decimal ProgressPercentage => GoalAmount > 0 ? (TotalRaised / GoalAmount) * 100 : 0;

        [Display(Name = "Days Remaining")]
        public int? DaysRemaining => EndDate?.Subtract(DateTime.Today).Days;
    }
}
