using System.ComponentModel.DataAnnotations;

namespace NonprofitTracker.Models
{
    public class Constituent
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Address Line 1")]
        [StringLength(100)]
        public string? AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(100)]
        public string? AddressLine2 { get; set; }

        [StringLength(50)]
        public string? City { get; set; }

        [StringLength(20)]
        public string? State { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(10)]
        public string? ZipCode { get; set; }

        [StringLength(50)]
        public string? Country { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(20)]
        public string? Gender { get; set; }

        [Display(Name = "Is Volunteer")]
        public bool IsVolunteer { get; set; }

        [Display(Name = "Preferred Communication")]
        public CommunicationPreference PreferredCommunication { get; set; } = CommunicationPreference.Email;

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        [StringLength(500)]
        public string? Notes { get; set; }

        // Navigation properties
        public virtual ICollection<Donation> Donations { get; set; } = new List<Donation>();
        public virtual ICollection<ConstituentProgram> ConstituentPrograms { get; set; } = new List<ConstituentProgram>();
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Full Address")]
        public string FullAddress
        {
            get
            {
                var parts = new List<string>();
                if (!string.IsNullOrEmpty(AddressLine1)) parts.Add(AddressLine1);
                if (!string.IsNullOrEmpty(AddressLine2)) parts.Add(AddressLine2);
                if (!string.IsNullOrEmpty(City)) parts.Add(City);
                if (!string.IsNullOrEmpty(State)) parts.Add(State);
                if (!string.IsNullOrEmpty(ZipCode)) parts.Add(ZipCode);
                return string.Join(", ", parts);
            }
        }
    }

    public enum CommunicationPreference
    {
        Email,
        Phone,
        Mail,
        Text
    }
}
