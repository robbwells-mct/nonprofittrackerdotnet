# AI4Fun.org - Nonprofit Tracker

A comprehensive .NET 8 web application designed for nonprofit organizations to track donations, manage constituents, and organize their fundraising activities.

## Features

### 📊 **Dashboard**
- Key metrics overview (total constituents, donations, campaigns, pending requests)
- Recent donations display
- Monthly donation trends visualization with Chart.js
- Quick action buttons for common tasks
- Campaign progress tracking with visual indicators

### 👥 **Constituent Management**
- Complete contact information tracking
- Demographics and volunteer status
- Communication preferences
- Advanced search and filtering capabilities
- Pagination with customizable page sizes
- Individual constituent profiles with donation history
- Quick action buttons for donations and service requests

### 💰 **Donation Tracking**
- Multiple gift types (Cash, Check, Credit Card, Stock, In-Kind, Pledge)
- Campaign association
- Recurring donation support with automatic scheduling
- Acknowledgment tracking with date stamps
- Comprehensive donation reporting
- Credit card last 4 digits storage for security

### 📢 **Campaign Management**
- Campaign creation and tracking
- Goal setting and progress monitoring
- Campaign-specific donation reports
- Active/inactive status management
- Start and end date tracking
- Real-time progress calculations

### 🎯 **Program Management**
- Program creation and enrollment tracking
- Constituent program participation
- Outcome and satisfaction tracking (1-5 rating scale)
- Program status management (Active, Completed, Withdrawn, On Hold)
- Enrollment and completion date tracking

### 🎫 **Service Request System**
- Request type categorization (General, Program Inquiry, Volunteer Opportunity, etc.)
- Priority levels (Low, Medium, High, Urgent)
- Status tracking (Pending, In Progress, Completed, Cancelled)
- Staff assignment and department tracking
- Due date management with overdue indicators
- Resolution tracking and notes
- Automatic date tracking for assignments and completions

### 📈 **Reporting & Analytics**
- Donation reports by campaign and gift type
- Constituent analytics with demographics breakdown
- Campaign performance analysis
- Service request analytics with trends
- Monthly donation trends
- Top donor analysis
- Geographic distribution reports
- Export capabilities (planned)

## Technology Stack

- **Framework**: ASP.NET Core 8.0 MVC
- **Database**: SQLite (easily configurable for SQL Server)
- **ORM**: Entity Framework Core 8.0
- **Authentication**: ASP.NET Core Identity
- **Frontend**: Bootstrap 5 with Bootstrap Icons
- **Charts**: Chart.js for data visualization
- **Styling**: Modern, responsive design with card-based layout

## Project Structure

```
NonprofitTracker/
├── Controllers/           # MVC Controllers
│   ├── HomeController.cs
│   ├── ConstituentsController.cs
│   ├── DonationsController.cs
│   ├── CampaignsController.cs
│   ├── ServiceRequestsController.cs
│   └── ReportsController.cs
├── Models/                # Data Models
│   ├── Constituent.cs
│   ├── Donation.cs
│   ├── Campaign.cs
│   ├── Program.cs
│   └── ServiceRequest.cs
├── ViewModels/            # View Models
│   └── ViewModels.cs
├── Data/                  # Database Context
│   └── ApplicationDbContext.cs
└── Views/                 # Razor Views
    ├── Home/
    ├── Constituents/
    ├── Shared/
    └── ...
```

## Key Models

### Constituent
- Personal information (name, contact details, address)
- Demographics (date of birth, gender)
- Communication preferences
- Volunteer status
- Related donations, programs, and service requests

### Donation
- Amount and gift type
- Campaign association (optional)
- Recurring donation support
- Acknowledgment tracking
- Payment method details (check number, credit card last 4)

### Campaign
- Name, description, and date ranges
- Goal amount and progress tracking
- Active/inactive status
- Associated donations

### Service Request
- Request details and categorization
- Priority and status management
- Staff assignment and department
- Due date and resolution tracking

### Program
- Program information and status
- Constituent enrollment tracking
- Outcome and satisfaction ratings

## Getting Started

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd nonprofittrackerdotnet/NonprofitTracker
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Access the application**
   - Open your browser to `https://localhost:5001` or `http://localhost:5000`
   - The database will be automatically created on first run

## Database

The application uses SQLite by default for easy development and deployment. The database is automatically created and seeded with sample data on first run.

### Seed Data Includes:
- Sample campaigns (Annual Giving Campaign 2025, Building Fund)
- Sample programs (Youth Development, Senior Services, Food Assistance)

## Features in Detail

### Dashboard
- Real-time metrics display
- Interactive charts for donation trends
- Quick access to common actions
- Campaign progress indicators with color coding
- Service request status summary

### Search & Filtering
- Advanced constituent search by name, email, location
- Filter by volunteer status and communication preferences
- Sortable columns with direction indicators
- Customizable pagination (10, 25, 50 results per page)

### User Experience
- Modern, responsive design
- Intuitive navigation with breadcrumbs
- Bootstrap 5 components for consistency
- Icon-driven interface with Bootstrap Icons
- Form validation with client-side feedback

## Planned Enhancements

- [ ] Export functionality (Excel, PDF)
- [ ] Email integration for acknowledgments
- [ ] Volunteer management module
- [ ] Event management
- [ ] Advanced reporting with custom date ranges
- [ ] API endpoints for integrations
- [ ] Multi-tenant support
- [ ] Advanced security features

## Contributing

This is a demonstration project for AI4Fun.org showcasing modern .NET development practices for nonprofit management applications.

## License

This project is created as part of AI4Fun.us educational content.
