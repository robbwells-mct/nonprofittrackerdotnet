using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NonprofitTracker.Models
{
    public class Donation
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Constituent")]
        public int ConstituentId { get; set; }

        [Display(Name = "Campaign")]
        public int? CampaignId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Display(Name = "Gift Type")]
        public GiftType GiftType { get; set; } = GiftType.Cash;

        [Display(Name = "Donation Type")]
        public DonationType DonationType { get; set; } = DonationType.OneTime;

        [Display(Name = "Donation Date")]
        public DateTime DonationDate { get; set; } = DateTime.Today;

        [Display(Name = "Is Recurring")]
        public bool IsRecurring { get; set; }

        [Display(Name = "Recurring Frequency")]
        public RecurringFrequency? RecurringFrequency { get; set; }

        [Display(Name = "Next Recurring Date")]
        public DateTime? NextRecurringDate { get; set; }

        [Display(Name = "Acknowledgment Status")]
        public AcknowledgmentStatus AcknowledgmentStatus { get; set; } = AcknowledgmentStatus.Pending;

        [Display(Name = "Acknowledgment Sent")]
        public bool AcknowledgmentSent { get; set; }

        [Display(Name = "Acknowledgment Date")]
        public DateTime? AcknowledgmentDate { get; set; }

        [Display(Name = "Check Number")]
        [StringLength(50)]
        public string? CheckNumber { get; set; }

        [Display(Name = "Credit Card Last 4")]
        [StringLength(4)]
        public string? CreditCardLast4 { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        [Display(Name = "Updated Date")]
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Constituent Constituent { get; set; } = null!;
        public virtual Campaign? Campaign { get; set; }
    }

    public enum GiftType
    {
        Cash,
        Check,
        [Display(Name = "Credit Card")]
        CreditCard,
        Stock,
        [Display(Name = "In-Kind")]
        InKind,
        Pledge
    }

    public enum RecurringFrequency
    {
        Weekly,
        Monthly,
        Quarterly,
        [Display(Name = "Semi-Annual")]
        SemiAnnual,
        Annual
    }

    public enum DonationType
    {
        [Display(Name = "One-Time")]
        OneTime,
        Recurring,
        Pledge,
        [Display(Name = "In-Kind")]
        InKind
    }

    public enum AcknowledgmentStatus
    {
        Pending,
        Sent,
        [Display(Name = "Not Required")]
        NotRequired,
        Failed
    }
}
