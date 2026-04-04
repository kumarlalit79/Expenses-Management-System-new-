# Expenses Management System (EMS)
> Manage, track, and visualize your daily and monthly expenses effortlessly.

## 🔗 Demo
<a href="https://youtu.be/slUmzh40Ylw">
  <img src="https://img.youtube.com/vi/slUmzh40Ylw/maxresdefault.jpg" alt="EMS Demo Video" width="800">
</a>

### [🎬 Click here to watch the live demo video!](https://youtu.be/slUmzh40Ylw)
<!-- Add screenshots here -->

## 📋 Description
The Expenses Management System (EMS) is a comprehensive web application designed to help individuals gain complete control over their finances. It allows users to track their spending habits by organizing expenses into default or customizable categories, subcategories, and sub-subcategories. With dynamic real-time charts, advanced time-based filtering, and detailed payment mode insights, EMS makes personal finance management intuitive, effective, and tailored to your unique spending patterns.

## ⚙️ Tech Stack
![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET_MVC-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity_Framework-B92B27?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white)
![jQuery](https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white)
![Highcharts](https://img.shields.io/badge/Highcharts-000000?style=for-the-badge&logo=highcharts&logoColor=white)

## ✨ Features
- **Dynamic Expense Tracking:** Seamlessly add, edit, delete, and monitor your daily and monthly expenses.
- **Hierarchical & Custom Categorization:** Organize spending using default or custom-created categories, subcategories, and sub-subcategories.
- **Advanced Dashboard Visualizations:** Interactive Line, Pie, and Column charts powered by Highcharts that automatically update as your data changes.
- **Time-Based Filtering:** Easily filter and view detailed expense breakdowns by selecting specific months and years.
- **Payment Mode Insights:** Track your spending across various payment methods (e.g., Cash, Credit Card, Bank) with table and graph representations.
- **One-Click Reports:** Export and download your monthly spending reports instantly in CSV or Excel formats.
- **User Authentication:** Secure login, account management, and user-specific isolated data.

## 💡 How It Works
1. **User Registration & Login:** Start by creating a secure account. Once authenticated, your data is securely isolated from other users.
2. **Setup Custom Categories:** While default categories are available, you can navigate to the category settings and define your own custom nested hierarchies (Category ➔ Sub-category ➔ Sub-sub-category) to match your exact spending habits.
3. **Log Expenses:** Add new expenses by entering the amount, selecting the relevant category hierarchy, specifying the date, picking a payment method (Card/Cash/UPI), and uploading an optional receipt image.
4. **Monitor the Dashboard:** Navigate to your dashboard where your logged expenses instantly render into dynamic charts (Line, Pie, Column charts). Use the dropdown filters to swap between months and years to visualize your spending trends over time.
5. **Generate Reports:** At the click of a button on the dashboard, export your filtered monthly datasets directly to CSV or Excel formats for external bookkeeping or financial planning.

## 📁 Project Structure
- `App_Start/` — Configuration for application routing, bundling, and filters.
- `Controllers/` — C# controllers managing the application logic (e.g., `DashboardController`, `ExpensesController`).
- `Models/` — Entity Framework models (`.edmx`) defining the database schema and relationships.
- `Views/` — Razor `.cshtml` pages and HTML files forming the frontend user interface.
- `Content/` — Static assets including Bootstrap CSS stylesheets, fonts, and images.
- `Scripts/` — Client-side JavaScript libraries like jQuery, Bootstrap JS, and Highcharts.
- `Upload_Img/` — Local storage directory for user-uploaded expense receipts and images.
- `DatabaseBackup/` — Contains `.bak` backup files for restoring the SQL Server database.

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2022 (or a compatible IDE)
- .NET Framework 4.8
- SQL Server (SQLEXPRESS or Developer Edition)
- Internet Information Services (IIS) Express

### Installation
1. Clone the repository to your local machine:
   ```bash
   git clone <repository-url>
   ```
2. Open the solution file `Expenses_Management_System.sln` using Visual Studio.
3. Restore NuGet packages (Right-click the Solution in Solution Explorer -> **Restore NuGet Packages**).
4. Set up the Database:
   - Open SQL Server Management Studio (SSMS).
   - Restore the database using the `Expenses.bak` file in the root directory, OR execute the `script.sql` file.
   - Open the `Web.config` file located in the `Expenses_Management_System` project folder.
   - Update the `connectionString` associated with `ExpensesEntities` to point to your local SQL Server instance.
5. Press `F5` or click **Start** in Visual Studio to build and launch the application in your browser.

### Environment Variables
| Variable | Description | Example |
| :--- | :--- | :--- |
| `ExpensesEntities` | The physical SQL Server connection string located inside the `<connectionStrings>` block in `Web.config`. | `data source=.\SQLEXPRESS;initial catalog=Expensesnew;...` |

## 🔌 API Endpoints
| Method | Route | Description |
| :--- | :--- | :--- |
| GET | `/Dashboard/Monthly_Spending_Details` | Retrieves a JSON list of the user's expenses for a given month. |
| GET | `/Dashboard/CategoryWiseSpending` | Returns JSON data of total spending aggregated by categories. |
| GET | `/Dashboard/Paymode` | Returns JSON data for charting expenses grouped by payment methods. |
| GET | `/Dashboard/GetSubCategoryWiseRPT` | Fetches aggregated expense data for nested sub-subcategories. |
| GET | `/Dashboard/DownloadFile` | Triggers the generation and download of expense reports (format query: `csv` or `excel`). |
| POST | `/Expenses/Create` | Creates a new expense entry with associated files and category details. |
| POST | `/Dashboard/MyAccountEdit` | Updates the authenticated user's profile and account information. |

## 👤 Author
Lalit Kumar — GitHub: [kumarlalit79](https://github.com/kumarlalit79)