using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NonprofitTracker.Models;

namespace NonprofitTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Constituent> Constituents { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Models.Program> Programs { get; set; }
        public DbSet<ConstituentProgram> ConstituentPrograms { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure decimal precision
            modelBuilder.Entity<Donation>()
                .Property(d => d.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Campaign>()
                .Property(c => c.GoalAmount)
                .HasColumnType("decimal(18,2)");

            // Configure relationships
            modelBuilder.Entity<Donation>()
                .HasOne(d => d.Constituent)
                .WithMany(c => c.Donations)
                .HasForeignKey(d => d.ConstituentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Donation>()
                .HasOne(d => d.Campaign)
                .WithMany(c => c.Donations)
                .HasForeignKey(d => d.CampaignId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ConstituentProgram>()
                .HasOne(cp => cp.Constituent)
                .WithMany(c => c.ConstituentPrograms)
                .HasForeignKey(cp => cp.ConstituentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ConstituentProgram>()
                .HasOne(cp => cp.Program)
                .WithMany(p => p.ConstituentPrograms)
                .HasForeignKey(cp => cp.ProgramId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(sr => sr.Constituent)
                .WithMany(c => c.ServiceRequests)
                .HasForeignKey(sr => sr.ConstituentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure indexes for better performance
            modelBuilder.Entity<Constituent>()
                .HasIndex(c => c.Email);

            modelBuilder.Entity<Constituent>()
                .HasIndex(c => new { c.LastName, c.FirstName });

            modelBuilder.Entity<Donation>()
                .HasIndex(d => d.DonationDate);

            modelBuilder.Entity<ServiceRequest>()
                .HasIndex(sr => sr.DateRequested);

            modelBuilder.Entity<ServiceRequest>()
                .HasIndex(sr => sr.Status);

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Campaigns
            modelBuilder.Entity<Campaign>().HasData(
                new Campaign
                {
                    Id = 1,
                    Name = "Annual Giving Campaign 2025",
                    Description = "Our annual fundraising campaign to support all programs",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 12, 31),
                    GoalAmount = 100000m,
                    IsActive = true,
                    DateCreated = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Campaign
                {
                    Id = 2,
                    Name = "Building Fund",
                    Description = "Capital campaign for new facility construction",
                    StartDate = new DateTime(2025, 3, 1),
                    EndDate = new DateTime(2026, 3, 1),
                    GoalAmount = 500000m,
                    IsActive = true,
                    DateCreated = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                }
            );

            // Seed Programs
            modelBuilder.Entity<Models.Program>().HasData(
                new Models.Program
                {
                    Id = 1,
                    Name = "Youth Development Program",
                    Description = "After-school program for at-risk youth",
                    IsActive = true,
                    DateCreated = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Models.Program
                {
                    Id = 2,
                    Name = "Senior Services",
                    Description = "Support services for elderly community members",
                    IsActive = true,
                    DateCreated = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Models.Program
                {
                    Id = 3,
                    Name = "Food Assistance Program",
                    Description = "Food bank and meal distribution services",
                    IsActive = true,
                    DateCreated = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                }
            );

            // Seed Donor Constituents
            modelBuilder.Entity<Constituent>().HasData(
                new Constituent
                {
                    Id = 1,
                    FirstName = "Emily",
                    LastName = "Johnson",
                    Email = "emily.johnson@email.com",
                    PhoneNumber = "(555) 123-4567",
                    AddressLine1 = "123 Oak Street",
                    City = "Springfield",
                    State = "IL",
                    ZipCode = "62701",
                    Gender = "Female",
                    IsVolunteer = true,
                    PreferredCommunication = CommunicationPreference.Email,
                    DateCreated = DateTime.UtcNow.AddMonths(-8),
                    LastUpdated = DateTime.UtcNow.AddMonths(-8)
                },
                new Constituent
                {
                    Id = 2,
                    FirstName = "Michael",
                    LastName = "Chen",
                    Email = "michael.chen@email.com",
                    PhoneNumber = "(555) 234-5678",
                    AddressLine1 = "456 Maple Avenue",
                    City = "Springfield",
                    State = "IL",
                    ZipCode = "62702",
                    Gender = "Male",
                    IsVolunteer = false,
                    PreferredCommunication = CommunicationPreference.Phone,
                    DateCreated = DateTime.UtcNow.AddMonths(-10),
                    LastUpdated = DateTime.UtcNow.AddMonths(-10)
                },
                new Constituent
                {
                    Id = 3,
                    FirstName = "Sarah",
                    LastName = "Williams",
                    Email = "sarah.williams@email.com",
                    PhoneNumber = "(555) 345-6789",
                    AddressLine1 = "789 Pine Road",
                    City = "Decatur",
                    State = "IL",
                    ZipCode = "62521",
                    Gender = "Female",
                    IsVolunteer = true,
                    PreferredCommunication = CommunicationPreference.Email,
                    DateCreated = DateTime.UtcNow.AddMonths(-6),
                    LastUpdated = DateTime.UtcNow.AddMonths(-6)
                },
                new Constituent
                {
                    Id = 4,
                    FirstName = "David",
                    LastName = "Rodriguez",
                    Email = "david.rodriguez@email.com",
                    PhoneNumber = "(555) 456-7890",
                    AddressLine1 = "321 Elm Street",
                    City = "Peoria",
                    State = "IL",
                    ZipCode = "61601",
                    Gender = "Male",
                    IsVolunteer = false,
                    PreferredCommunication = CommunicationPreference.Mail,
                    DateCreated = DateTime.UtcNow.AddMonths(-12),
                    LastUpdated = DateTime.UtcNow.AddMonths(-12)
                },
                new Constituent
                {
                    Id = 5,
                    FirstName = "Jennifer",
                    LastName = "Davis",
                    Email = "jennifer.davis@email.com",
                    PhoneNumber = "(555) 567-8901",
                    AddressLine1 = "654 Cedar Lane",
                    City = "Rockford",
                    State = "IL",
                    ZipCode = "61101",
                    Gender = "Female",
                    IsVolunteer = true,
                    PreferredCommunication = CommunicationPreference.Email,
                    DateCreated = DateTime.UtcNow.AddMonths(-4),
                    LastUpdated = DateTime.UtcNow.AddMonths(-4)
                },
                new Constituent
                {
                    Id = 6,
                    FirstName = "Robert",
                    LastName = "Thompson",
                    Email = "robert.thompson@email.com",
                    PhoneNumber = "(555) 678-9012",
                    AddressLine1 = "987 Birch Drive",
                    City = "Aurora",
                    State = "IL",
                    ZipCode = "60502",
                    Gender = "Male",
                    IsVolunteer = false,
                    PreferredCommunication = CommunicationPreference.Phone,
                    DateCreated = DateTime.UtcNow.AddMonths(-7),
                    LastUpdated = DateTime.UtcNow.AddMonths(-7)
                },
                new Constituent
                {
                    Id = 7,
                    FirstName = "Lisa",
                    LastName = "Anderson",
                    Email = "lisa.anderson@email.com",
                    PhoneNumber = "(555) 789-0123",
                    AddressLine1 = "147 Walnut Court",
                    City = "Naperville",
                    State = "IL",
                    ZipCode = "60540",
                    Gender = "Female",
                    IsVolunteer = true,
                    PreferredCommunication = CommunicationPreference.Email,
                    DateCreated = DateTime.UtcNow.AddMonths(-9),
                    LastUpdated = DateTime.UtcNow.AddMonths(-9)
                },
                new Constituent
                {
                    Id = 8,
                    FirstName = "James",
                    LastName = "Wilson",
                    Email = "james.wilson@email.com",
                    PhoneNumber = "(555) 890-1234",
                    AddressLine1 = "258 Hickory Street",
                    City = "Joliet",
                    State = "IL",
                    ZipCode = "60431",
                    Gender = "Male",
                    IsVolunteer = false,
                    PreferredCommunication = CommunicationPreference.Mail,
                    DateCreated = DateTime.UtcNow.AddMonths(-5),
                    LastUpdated = DateTime.UtcNow.AddMonths(-5)
                },
                new Constituent
                {
                    Id = 9,
                    FirstName = "Amanda",
                    LastName = "Garcia",
                    Email = "amanda.garcia@email.com",
                    PhoneNumber = "(555) 901-2345",
                    AddressLine1 = "369 Sycamore Avenue",
                    City = "Evanston",
                    State = "IL",
                    ZipCode = "60201",
                    Gender = "Female",
                    IsVolunteer = true,
                    PreferredCommunication = CommunicationPreference.Email,
                    DateCreated = DateTime.UtcNow.AddMonths(-3),
                    LastUpdated = DateTime.UtcNow.AddMonths(-3)
                },
                new Constituent
                {
                    Id = 10,
                    FirstName = "Christopher",
                    LastName = "Martinez",
                    Email = "christopher.martinez@email.com",
                    PhoneNumber = "(555) 012-3456",
                    AddressLine1 = "741 Poplar Boulevard",
                    City = "Champaign",
                    State = "IL",
                    ZipCode = "61820",
                    Gender = "Male",
                    IsVolunteer = false,
                    PreferredCommunication = CommunicationPreference.Phone,
                    DateCreated = DateTime.UtcNow.AddMonths(-11),
                    LastUpdated = DateTime.UtcNow.AddMonths(-11)
                }
            );

            // Seed Donations from these donors
            modelBuilder.Entity<Donation>().HasData(
                // Emily Johnson - Major Donor
                new Donation
                {
                    Id = 1,
                    ConstituentId = 1,
                    CampaignId = 1,
                    Amount = 5000m,
                    DonationDate = DateTime.UtcNow.AddDays(-120),
                    GiftType = GiftType.Cash,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-120),
                    LastUpdated = DateTime.UtcNow.AddDays(-120)
                },
                new Donation
                {
                    Id = 2,
                    ConstituentId = 1,
                    CampaignId = 2,
                    Amount = 10000m,
                    DonationDate = DateTime.UtcNow.AddDays(-60),
                    GiftType = GiftType.Check,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-60),
                    LastUpdated = DateTime.UtcNow.AddDays(-60)
                },
                // Michael Chen - Regular Donor
                new Donation
                {
                    Id = 3,
                    ConstituentId = 2,
                    CampaignId = 1,
                    Amount = 250m,
                    DonationDate = DateTime.UtcNow.AddDays(-90),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-90),
                    LastUpdated = DateTime.UtcNow.AddDays(-90)
                },
                new Donation
                {
                    Id = 4,
                    ConstituentId = 2,
                    CampaignId = 1,
                    Amount = 300m,
                    DonationDate = DateTime.UtcNow.AddDays(-30),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-30),
                    LastUpdated = DateTime.UtcNow.AddDays(-30)
                },
                // Sarah Williams - Monthly Donor
                new Donation
                {
                    Id = 5,
                    ConstituentId = 3,
                    CampaignId = 1,
                    Amount = 100m,
                    DonationDate = DateTime.UtcNow.AddDays(-150),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-150),
                    LastUpdated = DateTime.UtcNow.AddDays(-150)
                },
                new Donation
                {
                    Id = 6,
                    ConstituentId = 3,
                    CampaignId = 1,
                    Amount = 100m,
                    DonationDate = DateTime.UtcNow.AddDays(-120),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-120),
                    LastUpdated = DateTime.UtcNow.AddDays(-120)
                },
                new Donation
                {
                    Id = 7,
                    ConstituentId = 3,
                    CampaignId = 1,
                    Amount = 100m,
                    DonationDate = DateTime.UtcNow.AddDays(-90),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-90),
                    LastUpdated = DateTime.UtcNow.AddDays(-90)
                },
                // David Rodriguez - Large Single Donation
                new Donation
                {
                    Id = 8,
                    ConstituentId = 4,
                    CampaignId = 2,
                    Amount = 7500m,
                    DonationDate = DateTime.UtcNow.AddDays(-200),
                    GiftType = GiftType.Check,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-200),
                    LastUpdated = DateTime.UtcNow.AddDays(-200)
                },
                // Jennifer Davis - Regular Supporter
                new Donation
                {
                    Id = 9,
                    ConstituentId = 5,
                    CampaignId = 1,
                    Amount = 500m,
                    DonationDate = DateTime.UtcNow.AddDays(-75),
                    GiftType = GiftType.Cash,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-75),
                    LastUpdated = DateTime.UtcNow.AddDays(-75)
                },
                new Donation
                {
                    Id = 10,
                    ConstituentId = 5,
                    CampaignId = 2,
                    Amount = 750m,
                    DonationDate = DateTime.UtcNow.AddDays(-45),
                    GiftType = GiftType.Check,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-45),
                    LastUpdated = DateTime.UtcNow.AddDays(-45)
                },
                // Robert Thompson - Corporate Matching
                new Donation
                {
                    Id = 11,
                    ConstituentId = 6,
                    CampaignId = 1,
                    Amount = 1000m,
                    DonationDate = DateTime.UtcNow.AddDays(-180),
                    GiftType = GiftType.Stock,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-180),
                    LastUpdated = DateTime.UtcNow.AddDays(-180)
                },
                // Lisa Anderson - Event Donations
                new Donation
                {
                    Id = 12,
                    ConstituentId = 7,
                    CampaignId = 1,
                    Amount = 200m,
                    DonationDate = DateTime.UtcNow.AddDays(-100),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-100),
                    LastUpdated = DateTime.UtcNow.AddDays(-100)
                },
                new Donation
                {
                    Id = 13,
                    ConstituentId = 7,
                    CampaignId = 1,
                    Amount = 350m,
                    DonationDate = DateTime.UtcNow.AddDays(-50),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = false,
                    DateCreated = DateTime.UtcNow.AddDays(-50),
                    LastUpdated = DateTime.UtcNow.AddDays(-50)
                },
                // James Wilson - Annual Donor
                new Donation
                {
                    Id = 14,
                    ConstituentId = 8,
                    CampaignId = 1,
                    Amount = 2000m,
                    DonationDate = DateTime.UtcNow.AddDays(-365),
                    GiftType = GiftType.Check,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-365),
                    LastUpdated = DateTime.UtcNow.AddDays(-365)
                },
                new Donation
                {
                    Id = 15,
                    ConstituentId = 8,
                    CampaignId = 1,
                    Amount = 2500m,
                    DonationDate = DateTime.UtcNow.AddDays(-25),
                    GiftType = GiftType.Check,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-25),
                    LastUpdated = DateTime.UtcNow.AddDays(-25)
                },
                // Amanda Garcia - Young Professional
                new Donation
                {
                    Id = 16,
                    ConstituentId = 9,
                    CampaignId = 1,
                    Amount = 150m,
                    DonationDate = DateTime.UtcNow.AddDays(-80),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-80),
                    LastUpdated = DateTime.UtcNow.AddDays(-80)
                },
                new Donation
                {
                    Id = 17,
                    ConstituentId = 9,
                    CampaignId = 1,
                    Amount = 200m,
                    DonationDate = DateTime.UtcNow.AddDays(-15),
                    GiftType = GiftType.CreditCard,
                    AcknowledgmentSent = false,
                    DateCreated = DateTime.UtcNow.AddDays(-15),
                    LastUpdated = DateTime.UtcNow.AddDays(-15)
                },
                // Christopher Martinez - Memorial Donation
                new Donation
                {
                    Id = 18,
                    ConstituentId = 10,
                    CampaignId = 2,
                    Amount = 3000m,
                    DonationDate = DateTime.UtcNow.AddDays(-220),
                    GiftType = GiftType.Check,
                    AcknowledgmentSent = true,
                    DateCreated = DateTime.UtcNow.AddDays(-220),
                    LastUpdated = DateTime.UtcNow.AddDays(-220)
                }
            );
        }
    }
}
