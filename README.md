# PowerWise – Group 4

Electricity tracker (VB.NET Windows Forms) with login, per-user saved data and PDF/CSV export.

## The Problem
Households, hostel students and small businesses in Ghana on prepaid meters rarely know how fast their units are being used, so power cuts off without warning. The meter shows units left, but not which appliances or days use the most, and there is no usage history for budgeting.

## Our Solution
PowerWise turns meter readings and top-ups into clear usage insights: units left, average daily use and estimated days remaining, plus appliance energy planning and exportable reports.

## Group Members

| No. | Name | Index Number |
|-----|------|--------------|
| 1 | Juliet Anang | 10324090 |
| 2 | Dickson Owusu | 10322358 |
| 3 | Emmanuel Anane | 10334813 |
| 4 | Emmanuel Boateng | 10334600 |
| 5 | Kingsley Opare Akyea | 10334812 |
| 6 | Hamza Mukaila | 10334764 |
| 7 | Gilbert Saabon | 10334817 |
| 8 | Mary Ann Dzifa Konadu-Yeboah | 10334914 |
| 9 | Maxwell Addo | 10333901 |
| 10 | Doreen Anku | 10326593 |

## Demo Video (3 min)

[Watch the demo](https://youtu.be/qaxEjNKhGdM)

## Features
- **Dashboard** – units remaining, average daily usage, estimated days left, latest top-up, recent activity, daily energy tip
- **Meter Reading** – calculate units used
- **Top-Up** – record units bought and amount paid
- **Appliance Planner** – daily / monthly kWh of an appliance
- **Appliance Planner Reports** – export to PDF / CSV
- **Usage Reports** – meter readings and top-ups, export to PDF / CSV

## Project Files
- `LoginForm.vb` – username + 4–6 digit PIN, log in / create account
- `DataStore.vb` – accounts and per-user data in `%AppData%\PowerWise_Group4\` (PIN hashed with PBKDF2)
- `Theme.vb` – colours and styling
- `Program.vb` – login first, then main form
- `Form1.vb` / `Form1.Designer.vb` – main window

## How to Run
1. Install Visual Studio with the **.NET desktop development** workload (.NET 10 SDK).
2. Open `PowerWise_Group 4.slnx`.
3. Press **F5**.

PDF export uses Windows' built-in "Microsoft Print to PDF" printer.
