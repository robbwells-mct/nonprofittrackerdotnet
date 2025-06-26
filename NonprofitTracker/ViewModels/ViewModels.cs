using NonprofitTracker.Models;

namespace NonprofitTracker.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalConstituents { get; set; }
        public double TotalDonations { get; set; }
        public int TotalCampaigns { get; set; }
        public int PendingServiceRequests { get; set; }
        public int ActivePrograms { get; set; }
        
        public List<RecentDonation> RecentDonations { get; set; } = new();
        public List<MonthlyDonationTrend> MonthlyTrends { get; set; } = new();
        public List<CampaignProgress> CampaignProgress { get; set; } = new();
        public List<ServiceRequestSummary> ServiceRequestSummary { get; set; } = new();
    }

    public class RecentDonation
    {
        public string ConstituentName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string GiftType { get; set; } = string.Empty;
        public string? CampaignName { get; set; }
    }

    public class MonthlyDonationTrend
    {
        public string Month { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int DonationCount { get; set; }
    }

    public class CampaignProgress
    {
        public string CampaignName { get; set; } = string.Empty;
        public decimal GoalAmount { get; set; }
        public decimal RaisedAmount { get; set; }
        public decimal ProgressPercentage { get; set; }
        public int DaysRemaining { get; set; }
    }

    public class ServiceRequestSummary
    {
        public RequestStatus Status { get; set; }
        public int Count { get; set; }
    }

    public class ConstituentSearchViewModel
    {
        public string? SearchTerm { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public bool? IsVolunteer { get; set; }
        public CommunicationPreference? PreferredCommunication { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SortBy { get; set; } = "LastName";
        public string SortDirection { get; set; } = "asc";
        
        public List<Constituent> Results { get; set; } = new();
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    }

    public class DonationReportViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CampaignId { get; set; }
        public GiftType? GiftType { get; set; }
        
        public List<DonationReportItem> Donations { get; set; } = new();
        public decimal TotalAmount { get; set; }
        public int TotalCount { get; set; }
        
        public List<Campaign> AvailableCampaigns { get; set; } = new();
    }

    public class DonationReportItem
    {
        public DateTime Date { get; set; }
        public string ConstituentName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string GiftType { get; set; } = string.Empty;
        public string? CampaignName { get; set; }
        public bool AcknowledgmentSent { get; set; }
    }
}
