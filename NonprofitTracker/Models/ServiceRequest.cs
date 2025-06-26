using System.ComponentModel.DataAnnotations;

namespace NonprofitTracker.Models
{
    public class ServiceRequest
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Constituent")]
        public int ConstituentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Request Type")]
        public RequestType RequestType { get; set; } = RequestType.General;

        [Display(Name = "Priority")]
        public Priority Priority { get; set; } = Priority.Medium;

        [Display(Name = "Status")]
        public RequestStatus Status { get; set; } = RequestStatus.Pending;

        [Display(Name = "Assigned Staff")]
        [StringLength(100)]
        public string? AssignedStaff { get; set; }

        [Display(Name = "Department")]
        [StringLength(50)]
        public string? Department { get; set; }

        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;

        [Display(Name = "Date Assigned")]
        public DateTime? DateAssigned { get; set; }

        [Display(Name = "Date Completed")]
        public DateTime? DateCompleted { get; set; }

        [Display(Name = "Due Date")]
        public DateTime? DueDate { get; set; }

        [Display(Name = "Resolution Notes")]
        [StringLength(1000)]
        public string? ResolutionNotes { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Constituent Constituent { get; set; } = null!;

        [Display(Name = "Days Open")]
        public int DaysOpen => (DateTime.Today - DateRequested.Date).Days;

        [Display(Name = "Is Overdue")]
        public bool IsOverdue => DueDate.HasValue && DateTime.Today > DueDate.Value && Status != RequestStatus.Completed;
    }

    public enum RequestType
    {
        General,
        [Display(Name = "Program Inquiry")]
        ProgramInquiry,
        [Display(Name = "Volunteer Opportunity")]
        VolunteerOpportunity,
        [Display(Name = "Donation Question")]
        DonationQuestion,
        [Display(Name = "Event Information")]
        EventInformation,
        [Display(Name = "Technical Support")]
        TechnicalSupport,
        Complaint,
        [Display(Name = "Service Request")]
        ServiceRequest,
        Other
    }

    public enum Priority
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public enum RequestStatus
    {
        Pending,
        [Display(Name = "In Progress")]
        InProgress,
        Completed,
        Cancelled
    }
}
