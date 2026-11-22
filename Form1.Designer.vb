<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        pnlHeader = New Panel()
        lblTitle = New Label()
        lblWho = New Label()
        lblMenu = New Label()
        btnDashboard = New Button()
        btnReading = New Button()
        btnTopup = New Button()
        btnAppliances = New Button()
        btnApplReports = New Button()
        btnReports = New Button()
        btnLogout = New Button()
        pnlDashboard = New Panel()
        pnlReading = New Panel()
        pnlTopUp = New Panel()
        pnlPlanner = New Panel()
        pnlPlannerReports = New Panel()
        pnlReports = New Panel()
        cardBanner = New RoundPanel()
        lblWelcome = New Label()
        lblAlert = New Label()
        lblBolt = New Label()
        cardUnits = New RoundPanel()
        lblIcon1 = New Label()
        lblUnitsHeading = New Label()
        lblBalance = New Label()
        cardDaily = New RoundPanel()
        lblIcon2 = New Label()
        lblDailyHeading = New Label()
        lblDailyUsage = New Label()
        cardDays = New RoundPanel()
        lblIcon3 = New Label()
        lblDaysHeading = New Label()
        lblDaysLeft = New Label()
        cardTopUp = New RoundPanel()
        lblIcon4 = New Label()
        lblTopUpHeading = New Label()
        lblLatestTopUp = New Label()
        cardRecent = New RoundPanel()
        lblRecentTitle = New Label()
        lblRecent = New Label()
        cardTip = New RoundPanel()
        lblTipTitle = New Label()
        lblTip = New Label()
        cardReading = New RoundPanel()
        lblReadingTitle = New Label()
        lblReadingSub = New Label()
        lblPreviousCaption = New Label()
        pnlPreviousField = New RoundPanel()
        txtPrevious = New TextBox()
        lblCurrentCaption = New Label()
        pnlCurrentField = New RoundPanel()
        txtCurrent = New TextBox()
        lblDailyCaption = New Label()
        pnlDailyField = New RoundPanel()
        txtDaily = New TextBox()
        btnCalculate = New Button()
        btnClearReading = New Button()
        cardReadingInfo = New RoundPanel()
        lblReadingInfoTitle = New Label()
        lblReadingInfoBody = New Label()
        cardTopUpForm = New RoundPanel()
        lblTopUpTitle = New Label()
        lblTopUpSub = New Label()
        lblUnitsCaption = New Label()
        pnlUnitsField = New RoundPanel()
        txtTopUpUnits = New TextBox()
        lblAmountCaption = New Label()
        pnlAmountField = New RoundPanel()
        txtAmountPaid = New TextBox()
        btnRecordTopUp = New Button()
        cardTopUpInfo = New RoundPanel()
        lblTopUpInfoTitle = New Label()
        lblTopUpInfoBody = New Label()
        cardPlanner = New RoundPanel()
        lblPlannerTitle = New Label()
        lblPlannerSub = New Label()
        lblNameCaption = New Label()
        pnlNameField = New RoundPanel()
        txtApplianceName = New TextBox()
        lblWattsCaption = New Label()
        pnlWattsField = New RoundPanel()
        txtWattage = New TextBox()
        lblHoursCaption = New Label()
        pnlHoursField = New RoundPanel()
        txtHours = New TextBox()
        btnCalculateAppliance = New Button()
        btnClearAppliance = New Button()
        cardResult = New RoundPanel()
        lblResultTitle = New Label()
        lblApplianceResult = New Label()
        lblPlannerHint = New Label()
        btnApplOpen = New Button()
        cardHowCalc = New RoundPanel()
        lblHowCalcTitle = New Label()
        lblHowCalcBody = New Label()
        cardApplReports = New RoundPanel()
        lblApplReportsTitle = New Label()
        lblApplReportsSub = New Label()
        btnApplPdf = New Button()
        btnApplCsv = New Button()
        btnApplClear = New Button()
        dgvAppliances = New DataGridView()
        lblApplTotals = New Label()
        cardUsageReports = New RoundPanel()
        lblUsageReportsTitle = New Label()
        lblUsageReportsSub = New Label()
        btnExportPdf = New Button()
        btnExportCsv = New Button()
        btnRefreshReports = New Button()
        dgvUsageHistory = New DataGridView()
        lblUsageTotals = New Label()
        colDate = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colUnits = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colBalance = New DataGridViewTextBoxColumn()
        colApplDate = New DataGridViewTextBoxColumn()
        colApplName = New DataGridViewTextBoxColumn()
        colApplPower = New DataGridViewTextBoxColumn()
        colApplHours = New DataGridViewTextBoxColumn()
        colApplDaily = New DataGridViewTextBoxColumn()
        colApplMonthly = New DataGridViewTextBoxColumn()
        pnlSidebar.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlDashboard.SuspendLayout()
        pnlReading.SuspendLayout()
        pnlTopUp.SuspendLayout()
        pnlPlanner.SuspendLayout()
        pnlPlannerReports.SuspendLayout()
        pnlReports.SuspendLayout()
        cardBanner.SuspendLayout()
        cardUnits.SuspendLayout()
        cardDaily.SuspendLayout()
        cardDays.SuspendLayout()
        cardTopUp.SuspendLayout()
        cardRecent.SuspendLayout()
        cardTip.SuspendLayout()
        cardReading.SuspendLayout()
        pnlPreviousField.SuspendLayout()
        pnlCurrentField.SuspendLayout()
        pnlDailyField.SuspendLayout()
        cardReadingInfo.SuspendLayout()
        cardTopUpForm.SuspendLayout()
        pnlUnitsField.SuspendLayout()
        pnlAmountField.SuspendLayout()
        cardTopUpInfo.SuspendLayout()
        cardPlanner.SuspendLayout()
        pnlNameField.SuspendLayout()
        pnlWattsField.SuspendLayout()
        pnlHoursField.SuspendLayout()
        cardResult.SuspendLayout()
        cardHowCalc.SuspendLayout()
        cardApplReports.SuspendLayout()
        cardUsageReports.SuspendLayout()
        CType(dgvUsageHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAppliances, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.Controls.Add(lblMenu)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(btnReading)
        pnlSidebar.Controls.Add(btnTopup)
        pnlSidebar.Controls.Add(btnAppliances)
        pnlSidebar.Controls.Add(btnApplReports)
        pnlSidebar.Controls.Add(btnReports)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlSidebar.BackColor = Color.FromArgb(58, 42, 38)
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Size = New Size(250, 740)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblWho)
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.BackColor = Color.FromArgb(184, 80, 66)
        pnlHeader.Location = New Point(250, 0)
        pnlHeader.Size = New Size(930, 64)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(22, 11)
        lblTitle.Text = "⚡ PowerWise"
        lblTitle.Name = "lblTitle"
        lblTitle.TabIndex = 0
        ' 
        ' lblWho
        ' 
        lblWho.AutoSize = True
        lblWho.BackColor = Color.Transparent
        lblWho.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblWho.ForeColor = Color.White
        lblWho.Location = New Point(790, 21)
        lblWho.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWho.Text = "👤  User"
        lblWho.Name = "lblWho"
        lblWho.TabIndex = 1
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.BackColor = Color.Transparent
        lblMenu.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblMenu.ForeColor = Color.FromArgb(201, 168, 157)
        lblMenu.Location = New Point(28, 26)
        lblMenu.Text = "MENU"
        lblMenu.Name = "lblMenu"
        lblMenu.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(58, 42, 38)
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 80, 66)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 64, 58)
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10F)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(12, 56)
        btnDashboard.Padding = New Padding(14, 0, 0, 0)
        btnDashboard.Size = New Size(226, 44)
        btnDashboard.Text = "🏠  Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        btnDashboard.Name = "btnDashboard"
        btnDashboard.TabIndex = 1
        ' 
        ' btnReading
        ' 
        btnReading.BackColor = Color.FromArgb(58, 42, 38)
        btnReading.Cursor = Cursors.Hand
        btnReading.FlatAppearance.BorderSize = 0
        btnReading.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 80, 66)
        btnReading.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 64, 58)
        btnReading.FlatStyle = FlatStyle.Flat
        btnReading.Font = New Font("Segoe UI", 10F)
        btnReading.ForeColor = Color.White
        btnReading.Location = New Point(12, 110)
        btnReading.Padding = New Padding(14, 0, 0, 0)
        btnReading.Size = New Size(226, 44)
        btnReading.Text = "📟  Meter Reading"
        btnReading.TextAlign = ContentAlignment.MiddleLeft
        btnReading.UseVisualStyleBackColor = False
        btnReading.Name = "btnReading"
        btnReading.TabIndex = 2
        ' 
        ' btnTopup
        ' 
        btnTopup.BackColor = Color.FromArgb(58, 42, 38)
        btnTopup.Cursor = Cursors.Hand
        btnTopup.FlatAppearance.BorderSize = 0
        btnTopup.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 80, 66)
        btnTopup.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 64, 58)
        btnTopup.FlatStyle = FlatStyle.Flat
        btnTopup.Font = New Font("Segoe UI", 10F)
        btnTopup.ForeColor = Color.White
        btnTopup.Location = New Point(12, 164)
        btnTopup.Padding = New Padding(14, 0, 0, 0)
        btnTopup.Size = New Size(226, 44)
        btnTopup.Text = "💳  Top-Up"
        btnTopup.TextAlign = ContentAlignment.MiddleLeft
        btnTopup.UseVisualStyleBackColor = False
        btnTopup.Name = "btnTopup"
        btnTopup.TabIndex = 3
        ' 
        ' btnAppliances
        ' 
        btnAppliances.BackColor = Color.FromArgb(58, 42, 38)
        btnAppliances.Cursor = Cursors.Hand
        btnAppliances.FlatAppearance.BorderSize = 0
        btnAppliances.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 80, 66)
        btnAppliances.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 64, 58)
        btnAppliances.FlatStyle = FlatStyle.Flat
        btnAppliances.Font = New Font("Segoe UI", 10F)
        btnAppliances.ForeColor = Color.White
        btnAppliances.Location = New Point(12, 218)
        btnAppliances.Padding = New Padding(14, 0, 0, 0)
        btnAppliances.Size = New Size(226, 44)
        btnAppliances.Text = "🔌  Appliance Planner"
        btnAppliances.TextAlign = ContentAlignment.MiddleLeft
        btnAppliances.UseVisualStyleBackColor = False
        btnAppliances.Name = "btnAppliances"
        btnAppliances.TabIndex = 4
        ' 
        ' btnApplReports
        ' 
        btnApplReports.BackColor = Color.FromArgb(58, 42, 38)
        btnApplReports.Cursor = Cursors.Hand
        btnApplReports.FlatAppearance.BorderSize = 0
        btnApplReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 80, 66)
        btnApplReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 64, 58)
        btnApplReports.FlatStyle = FlatStyle.Flat
        btnApplReports.Font = New Font("Segoe UI", 10F)
        btnApplReports.ForeColor = Color.White
        btnApplReports.Location = New Point(12, 272)
        btnApplReports.Padding = New Padding(14, 0, 0, 0)
        btnApplReports.Size = New Size(226, 44)
        btnApplReports.Text = "🧾  Appliance Planner Reports"
        btnApplReports.TextAlign = ContentAlignment.MiddleLeft
        btnApplReports.UseVisualStyleBackColor = False
        btnApplReports.Name = "btnApplReports"
        btnApplReports.TabIndex = 5
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.FromArgb(58, 42, 38)
        btnReports.Cursor = Cursors.Hand
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 80, 66)
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 64, 58)
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 10F)
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(12, 326)
        btnReports.Padding = New Padding(14, 0, 0, 0)
        btnReports.Size = New Size(226, 44)
        btnReports.Text = "📈  Usage Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = False
        btnReports.Name = "btnReports"
        btnReports.TabIndex = 6
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogout.BackColor = Color.FromArgb(58, 42, 38)
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnLogout.FlatAppearance.BorderSize = 1
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 80, 66)
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(24, 676)
        btnLogout.Size = New Size(202, 40)
        btnLogout.Text = "🚪  Log out"
        btnLogout.UseVisualStyleBackColor = False
        btnLogout.Name = "btnLogout"
        btnLogout.TabIndex = 7
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Controls.Add(cardBanner)
        pnlDashboard.Controls.Add(cardUnits)
        pnlDashboard.Controls.Add(cardDaily)
        pnlDashboard.Controls.Add(cardDays)
        pnlDashboard.Controls.Add(cardTopUp)
        pnlDashboard.Controls.Add(cardRecent)
        pnlDashboard.Controls.Add(cardTip)
        pnlDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDashboard.BackColor = Color.FromArgb(247, 239, 233)
        pnlDashboard.Location = New Point(250, 64)
        pnlDashboard.Size = New Size(930, 676)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.TabIndex = 2
        ' 
        ' pnlReading
        ' 
        pnlReading.Controls.Add(cardReading)
        pnlReading.Controls.Add(cardReadingInfo)
        pnlReading.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlReading.BackColor = Color.FromArgb(247, 239, 233)
        pnlReading.Location = New Point(250, 64)
        pnlReading.Size = New Size(930, 676)
        pnlReading.Visible = False
        pnlReading.Name = "pnlReading"
        pnlReading.TabIndex = 3
        ' 
        ' pnlTopUp
        ' 
        pnlTopUp.Controls.Add(cardTopUpForm)
        pnlTopUp.Controls.Add(cardTopUpInfo)
        pnlTopUp.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTopUp.BackColor = Color.FromArgb(247, 239, 233)
        pnlTopUp.Location = New Point(250, 64)
        pnlTopUp.Size = New Size(930, 676)
        pnlTopUp.Visible = False
        pnlTopUp.Name = "pnlTopUp"
        pnlTopUp.TabIndex = 4
        ' 
        ' pnlPlanner
        ' 
        pnlPlanner.Controls.Add(cardPlanner)
        pnlPlanner.Controls.Add(cardResult)
        pnlPlanner.Controls.Add(cardHowCalc)
        pnlPlanner.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPlanner.BackColor = Color.FromArgb(247, 239, 233)
        pnlPlanner.Location = New Point(250, 64)
        pnlPlanner.Size = New Size(930, 676)
        pnlPlanner.Visible = False
        pnlPlanner.Name = "pnlPlanner"
        pnlPlanner.TabIndex = 5
        ' 
        ' pnlPlannerReports
        ' 
        pnlPlannerReports.Controls.Add(cardApplReports)
        pnlPlannerReports.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPlannerReports.BackColor = Color.FromArgb(247, 239, 233)
        pnlPlannerReports.Location = New Point(250, 64)
        pnlPlannerReports.Size = New Size(930, 676)
        pnlPlannerReports.Visible = False
        pnlPlannerReports.Name = "pnlPlannerReports"
        pnlPlannerReports.TabIndex = 6
        ' 
        ' pnlReports
        ' 
        pnlReports.Controls.Add(cardUsageReports)
        pnlReports.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlReports.BackColor = Color.FromArgb(247, 239, 233)
        pnlReports.Location = New Point(250, 64)
        pnlReports.Size = New Size(930, 676)
        pnlReports.Visible = False
        pnlReports.Name = "pnlReports"
        pnlReports.TabIndex = 7
        ' 
        ' cardBanner
        ' 
        cardBanner.Controls.Add(lblWelcome)
        cardBanner.Controls.Add(lblAlert)
        cardBanner.Controls.Add(lblBolt)
        cardBanner.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardBanner.FillColor = Color.White
        cardBanner.GradFrom = Color.FromArgb(58, 42, 38)
        cardBanner.GradTo = Color.FromArgb(184, 80, 66)
        cardBanner.Location = New Point(20, 20)
        cardBanner.Radius = 18
        cardBanner.Size = New Size(890, 108)
        cardBanner.Name = "cardBanner"
        cardBanner.TabIndex = 0
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(28, 14)
        lblWelcome.Text = "Welcome back 👋"
        lblWelcome.Name = "lblWelcome"
        lblWelcome.TabIndex = 0
        ' 
        ' lblAlert
        ' 
        lblAlert.AutoSize = False
        lblAlert.BackColor = Color.Transparent
        lblAlert.Font = New Font("Segoe UI", 11F)
        lblAlert.ForeColor = Color.White
        lblAlert.Location = New Point(30, 62)
        lblAlert.Size = New Size(710, 30)
        lblAlert.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAlert.Text = "Add a meter reading or a top-up to get started."
        lblAlert.Name = "lblAlert"
        lblAlert.TabIndex = 1
        ' 
        ' lblBolt
        ' 
        lblBolt.AutoSize = True
        lblBolt.BackColor = Color.Transparent
        lblBolt.Font = New Font("Segoe UI", 38F)
        lblBolt.ForeColor = Color.FromArgb(255, 255, 214, 140)
        lblBolt.Location = New Point(790, 20)
        lblBolt.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblBolt.Text = "⚡"
        lblBolt.Name = "lblBolt"
        lblBolt.TabIndex = 2
        ' 
        ' cardUnits
        ' 
        cardUnits.Controls.Add(lblIcon1)
        cardUnits.Controls.Add(lblUnitsHeading)
        cardUnits.Controls.Add(lblBalance)
        cardUnits.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardUnits.FillColor = Color.White
        cardUnits.StripeColor = Color.FromArgb(184, 80, 66)
        cardUnits.Location = New Point(20, 144)
        cardUnits.Radius = 18
        cardUnits.Size = New Size(212, 120)
        cardUnits.Name = "cardUnits"
        cardUnits.TabIndex = 1
        ' 
        ' lblIcon1
        ' 
        lblIcon1.AutoSize = True
        lblIcon1.BackColor = Color.Transparent
        lblIcon1.Font = New Font("Segoe UI", 22F)
        lblIcon1.ForeColor = Color.FromArgb(184, 80, 66)
        lblIcon1.Location = New Point(150, 12)
        lblIcon1.Text = "⚡"
        lblIcon1.Name = "lblIcon1"
        lblIcon1.TabIndex = 0
        ' 
        ' lblUnitsHeading
        ' 
        lblUnitsHeading.AutoSize = True
        lblUnitsHeading.BackColor = Color.Transparent
        lblUnitsHeading.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblUnitsHeading.ForeColor = Color.FromArgb(138, 115, 108)
        lblUnitsHeading.Location = New Point(22, 18)
        lblUnitsHeading.Text = "Units Remaining"
        lblUnitsHeading.Name = "lblUnitsHeading"
        lblUnitsHeading.TabIndex = 1
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.BackColor = Color.Transparent
        lblBalance.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        lblBalance.ForeColor = Color.FromArgb(184, 80, 66)
        lblBalance.Location = New Point(20, 60)
        lblBalance.Text = "0.00 kWh"
        lblBalance.Name = "lblBalance"
        lblBalance.TabIndex = 2
        ' 
        ' cardDaily
        ' 
        cardDaily.Controls.Add(lblIcon2)
        cardDaily.Controls.Add(lblDailyHeading)
        cardDaily.Controls.Add(lblDailyUsage)
        cardDaily.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardDaily.FillColor = Color.White
        cardDaily.StripeColor = Color.FromArgb(208, 128, 26)
        cardDaily.Location = New Point(246, 144)
        cardDaily.Radius = 18
        cardDaily.Size = New Size(212, 120)
        cardDaily.Name = "cardDaily"
        cardDaily.TabIndex = 2
        ' 
        ' lblIcon2
        ' 
        lblIcon2.AutoSize = True
        lblIcon2.BackColor = Color.Transparent
        lblIcon2.Font = New Font("Segoe UI", 22F)
        lblIcon2.ForeColor = Color.FromArgb(208, 128, 26)
        lblIcon2.Location = New Point(150, 12)
        lblIcon2.Text = "📊"
        lblIcon2.Name = "lblIcon2"
        lblIcon2.TabIndex = 0
        ' 
        ' lblDailyHeading
        ' 
        lblDailyHeading.AutoSize = True
        lblDailyHeading.BackColor = Color.Transparent
        lblDailyHeading.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDailyHeading.ForeColor = Color.FromArgb(138, 115, 108)
        lblDailyHeading.Location = New Point(22, 18)
        lblDailyHeading.Text = "Average Daily Usage"
        lblDailyHeading.Name = "lblDailyHeading"
        lblDailyHeading.TabIndex = 1
        ' 
        ' lblDailyUsage
        ' 
        lblDailyUsage.AutoSize = True
        lblDailyUsage.BackColor = Color.Transparent
        lblDailyUsage.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        lblDailyUsage.ForeColor = Color.FromArgb(208, 128, 26)
        lblDailyUsage.Location = New Point(20, 60)
        lblDailyUsage.Text = "0.00 kWh"
        lblDailyUsage.Name = "lblDailyUsage"
        lblDailyUsage.TabIndex = 2
        ' 
        ' cardDays
        ' 
        cardDays.Controls.Add(lblIcon3)
        cardDays.Controls.Add(lblDaysHeading)
        cardDays.Controls.Add(lblDaysLeft)
        cardDays.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardDays.FillColor = Color.White
        cardDays.StripeColor = Color.FromArgb(42, 157, 143)
        cardDays.Location = New Point(472, 144)
        cardDays.Radius = 18
        cardDays.Size = New Size(212, 120)
        cardDays.Name = "cardDays"
        cardDays.TabIndex = 3
        ' 
        ' lblIcon3
        ' 
        lblIcon3.AutoSize = True
        lblIcon3.BackColor = Color.Transparent
        lblIcon3.Font = New Font("Segoe UI", 22F)
        lblIcon3.ForeColor = Color.FromArgb(42, 157, 143)
        lblIcon3.Location = New Point(150, 12)
        lblIcon3.Text = "📅"
        lblIcon3.Name = "lblIcon3"
        lblIcon3.TabIndex = 0
        ' 
        ' lblDaysHeading
        ' 
        lblDaysHeading.AutoSize = True
        lblDaysHeading.BackColor = Color.Transparent
        lblDaysHeading.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDaysHeading.ForeColor = Color.FromArgb(138, 115, 108)
        lblDaysHeading.Location = New Point(22, 18)
        lblDaysHeading.Text = "Estimated Days Left"
        lblDaysHeading.Name = "lblDaysHeading"
        lblDaysHeading.TabIndex = 1
        ' 
        ' lblDaysLeft
        ' 
        lblDaysLeft.AutoSize = True
        lblDaysLeft.BackColor = Color.Transparent
        lblDaysLeft.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        lblDaysLeft.ForeColor = Color.FromArgb(42, 157, 143)
        lblDaysLeft.Location = New Point(20, 60)
        lblDaysLeft.Text = "0 days"
        lblDaysLeft.Name = "lblDaysLeft"
        lblDaysLeft.TabIndex = 2
        ' 
        ' cardTopUp
        ' 
        cardTopUp.Controls.Add(lblIcon4)
        cardTopUp.Controls.Add(lblTopUpHeading)
        cardTopUp.Controls.Add(lblLatestTopUp)
        cardTopUp.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardTopUp.FillColor = Color.White
        cardTopUp.StripeColor = Color.FromArgb(91, 140, 58)
        cardTopUp.Location = New Point(698, 144)
        cardTopUp.Radius = 18
        cardTopUp.Size = New Size(212, 120)
        cardTopUp.Name = "cardTopUp"
        cardTopUp.TabIndex = 4
        ' 
        ' lblIcon4
        ' 
        lblIcon4.AutoSize = True
        lblIcon4.BackColor = Color.Transparent
        lblIcon4.Font = New Font("Segoe UI", 22F)
        lblIcon4.ForeColor = Color.FromArgb(91, 140, 58)
        lblIcon4.Location = New Point(150, 12)
        lblIcon4.Text = "💳"
        lblIcon4.Name = "lblIcon4"
        lblIcon4.TabIndex = 0
        ' 
        ' lblTopUpHeading
        ' 
        lblTopUpHeading.AutoSize = True
        lblTopUpHeading.BackColor = Color.Transparent
        lblTopUpHeading.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblTopUpHeading.ForeColor = Color.FromArgb(138, 115, 108)
        lblTopUpHeading.Location = New Point(22, 18)
        lblTopUpHeading.Text = "Latest Top-Up"
        lblTopUpHeading.Name = "lblTopUpHeading"
        lblTopUpHeading.TabIndex = 1
        ' 
        ' lblLatestTopUp
        ' 
        lblLatestTopUp.AutoSize = True
        lblLatestTopUp.BackColor = Color.Transparent
        lblLatestTopUp.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        lblLatestTopUp.ForeColor = Color.FromArgb(91, 140, 58)
        lblLatestTopUp.Location = New Point(20, 60)
        lblLatestTopUp.Text = "None"
        lblLatestTopUp.Name = "lblLatestTopUp"
        lblLatestTopUp.TabIndex = 2
        ' 
        ' cardRecent
        ' 
        cardRecent.Controls.Add(lblRecentTitle)
        cardRecent.Controls.Add(lblRecent)
        cardRecent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cardRecent.FillColor = Color.White
        cardRecent.Location = New Point(20, 280)
        cardRecent.Radius = 18
        cardRecent.Size = New Size(574, 376)
        cardRecent.Name = "cardRecent"
        cardRecent.TabIndex = 5
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblRecentTitle.ForeColor = Color.FromArgb(58, 42, 38)
        lblRecentTitle.Location = New Point(24, 18)
        lblRecentTitle.Text = "🕒 Recent activity"
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.TabIndex = 0
        ' 
        ' lblRecent
        ' 
        lblRecent.AutoSize = True
        lblRecent.BackColor = Color.Transparent
        lblRecent.Font = New Font("Segoe UI", 10.5F)
        lblRecent.ForeColor = Color.FromArgb(58, 42, 38)
        lblRecent.Location = New Point(24, 60)
        lblRecent.MaximumSize = New Size(522, 0)
        lblRecent.Text = "Nothing yet – record a meter reading or a top-up and it will show up here."
        lblRecent.Name = "lblRecent"
        lblRecent.TabIndex = 1
        ' 
        ' cardTip
        ' 
        cardTip.Controls.Add(lblTipTitle)
        cardTip.Controls.Add(lblTip)
        cardTip.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cardTip.FillColor = Color.White
        cardTip.GradFrom = Color.FromArgb(232, 154, 60)
        cardTip.GradTo = Color.FromArgb(184, 80, 66)
        cardTip.Location = New Point(610, 280)
        cardTip.Radius = 18
        cardTip.Size = New Size(300, 376)
        cardTip.Name = "cardTip"
        cardTip.TabIndex = 6
        ' 
        ' lblTipTitle
        ' 
        lblTipTitle.AutoSize = True
        lblTipTitle.BackColor = Color.Transparent
        lblTipTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTipTitle.ForeColor = Color.White
        lblTipTitle.Location = New Point(24, 18)
        lblTipTitle.Text = "💡 Energy tip"
        lblTipTitle.Name = "lblTipTitle"
        lblTipTitle.TabIndex = 0
        ' 
        ' lblTip
        ' 
        lblTip.AutoSize = True
        lblTip.BackColor = Color.Transparent
        lblTip.Font = New Font("Segoe UI", 11F)
        lblTip.ForeColor = Color.White
        lblTip.Location = New Point(24, 60)
        lblTip.MaximumSize = New Size(248, 0)
        lblTip.Text = "Switch appliances off at the socket – standby power quietly eats your units."
        lblTip.Name = "lblTip"
        lblTip.TabIndex = 1
        ' 
        ' cardReading
        ' 
        cardReading.Controls.Add(lblReadingTitle)
        cardReading.Controls.Add(lblReadingSub)
        cardReading.Controls.Add(lblPreviousCaption)
        cardReading.Controls.Add(pnlPreviousField)
        cardReading.Controls.Add(lblCurrentCaption)
        cardReading.Controls.Add(pnlCurrentField)
        cardReading.Controls.Add(lblDailyCaption)
        cardReading.Controls.Add(pnlDailyField)
        cardReading.Controls.Add(btnCalculate)
        cardReading.Controls.Add(btnClearReading)
        cardReading.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardReading.FillColor = Color.White
        cardReading.Location = New Point(20, 20)
        cardReading.Radius = 18
        cardReading.Size = New Size(500, 392)
        cardReading.Name = "cardReading"
        cardReading.TabIndex = 0
        ' 
        ' lblReadingTitle
        ' 
        lblReadingTitle.AutoSize = True
        lblReadingTitle.BackColor = Color.Transparent
        lblReadingTitle.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        lblReadingTitle.ForeColor = Color.FromArgb(58, 42, 38)
        lblReadingTitle.Location = New Point(28, 22)
        lblReadingTitle.Text = "📟 Meter Reading"
        lblReadingTitle.Name = "lblReadingTitle"
        lblReadingTitle.TabIndex = 0
        ' 
        ' lblReadingSub
        ' 
        lblReadingSub.AutoSize = True
        lblReadingSub.BackColor = Color.Transparent
        lblReadingSub.Font = New Font("Segoe UI", 10F)
        lblReadingSub.ForeColor = Color.FromArgb(138, 115, 108)
        lblReadingSub.Location = New Point(30, 58)
        lblReadingSub.Text = "Enter your prepaid meter figures."
        lblReadingSub.Name = "lblReadingSub"
        lblReadingSub.TabIndex = 1
        ' 
        ' lblPreviousCaption
        ' 
        lblPreviousCaption.AutoSize = True
        lblPreviousCaption.BackColor = Color.Transparent
        lblPreviousCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblPreviousCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblPreviousCaption.Location = New Point(28, 98)
        lblPreviousCaption.Text = "Previous units (kWh)"
        lblPreviousCaption.Name = "lblPreviousCaption"
        lblPreviousCaption.TabIndex = 2
        ' 
        ' pnlPreviousField
        ' 
        pnlPreviousField.Controls.Add(txtPrevious)
        pnlPreviousField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPreviousField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlPreviousField.FillColor = Color.White
        pnlPreviousField.Location = New Point(28, 122)
        pnlPreviousField.Radius = 10
        pnlPreviousField.Shadow = False
        pnlPreviousField.Size = New Size(444, 40)
        pnlPreviousField.Name = "pnlPreviousField"
        pnlPreviousField.TabIndex = 3
        ' 
        ' txtPrevious
        ' 
        txtPrevious.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPrevious.BackColor = Color.White
        txtPrevious.BorderStyle = BorderStyle.None
        txtPrevious.Font = New Font("Segoe UI", 12F)
        txtPrevious.Location = New Point(14, 8)
        txtPrevious.Size = New Size(416, 23)
        txtPrevious.Name = "txtPrevious"
        txtPrevious.TabIndex = 0
        ' 
        ' lblCurrentCaption
        ' 
        lblCurrentCaption.AutoSize = True
        lblCurrentCaption.BackColor = Color.Transparent
        lblCurrentCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblCurrentCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblCurrentCaption.Location = New Point(28, 174)
        lblCurrentCaption.Text = "Current units (kWh)"
        lblCurrentCaption.Name = "lblCurrentCaption"
        lblCurrentCaption.TabIndex = 4
        ' 
        ' pnlCurrentField
        ' 
        pnlCurrentField.Controls.Add(txtCurrent)
        pnlCurrentField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlCurrentField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlCurrentField.FillColor = Color.White
        pnlCurrentField.Location = New Point(28, 198)
        pnlCurrentField.Radius = 10
        pnlCurrentField.Shadow = False
        pnlCurrentField.Size = New Size(444, 40)
        pnlCurrentField.Name = "pnlCurrentField"
        pnlCurrentField.TabIndex = 5
        ' 
        ' txtCurrent
        ' 
        txtCurrent.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCurrent.BackColor = Color.White
        txtCurrent.BorderStyle = BorderStyle.None
        txtCurrent.Font = New Font("Segoe UI", 12F)
        txtCurrent.Location = New Point(14, 8)
        txtCurrent.Size = New Size(416, 23)
        txtCurrent.Name = "txtCurrent"
        txtCurrent.TabIndex = 0
        ' 
        ' lblDailyCaption
        ' 
        lblDailyCaption.AutoSize = True
        lblDailyCaption.BackColor = Color.Transparent
        lblDailyCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDailyCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblDailyCaption.Location = New Point(28, 250)
        lblDailyCaption.Text = "Average daily usage (kWh)"
        lblDailyCaption.Name = "lblDailyCaption"
        lblDailyCaption.TabIndex = 6
        ' 
        ' pnlDailyField
        ' 
        pnlDailyField.Controls.Add(txtDaily)
        pnlDailyField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDailyField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlDailyField.FillColor = Color.White
        pnlDailyField.Location = New Point(28, 274)
        pnlDailyField.Radius = 10
        pnlDailyField.Shadow = False
        pnlDailyField.Size = New Size(444, 40)
        pnlDailyField.Name = "pnlDailyField"
        pnlDailyField.TabIndex = 7
        ' 
        ' txtDaily
        ' 
        txtDaily.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDaily.BackColor = Color.White
        txtDaily.BorderStyle = BorderStyle.None
        txtDaily.Font = New Font("Segoe UI", 12F)
        txtDaily.Location = New Point(14, 8)
        txtDaily.Size = New Size(416, 23)
        txtDaily.Name = "txtDaily"
        txtDaily.TabIndex = 0
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnCalculate.BackColor = Color.FromArgb(184, 80, 66)
        btnCalculate.Cursor = Cursors.Hand
        btnCalculate.FlatAppearance.BorderSize = 0
        btnCalculate.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 42, 38)
        btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 63, 51)
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.White
        btnCalculate.Location = New Point(28, 330)
        btnCalculate.Size = New Size(300, 46)
        btnCalculate.Text = "⚡  Calculate Usage"
        btnCalculate.UseVisualStyleBackColor = False
        btnCalculate.Name = "btnCalculate"
        btnCalculate.TabIndex = 8
        ' 
        ' btnClearReading
        ' 
        btnClearReading.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnClearReading.BackColor = Color.White
        btnClearReading.Cursor = Cursors.Hand
        btnClearReading.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnClearReading.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 241, 236)
        btnClearReading.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 241, 236)
        btnClearReading.FlatStyle = FlatStyle.Flat
        btnClearReading.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnClearReading.ForeColor = Color.FromArgb(184, 80, 66)
        btnClearReading.Location = New Point(342, 330)
        btnClearReading.Size = New Size(130, 46)
        btnClearReading.Text = "🧹  Clear"
        btnClearReading.UseVisualStyleBackColor = False
        btnClearReading.Name = "btnClearReading"
        btnClearReading.TabIndex = 9
        ' 
        ' cardReadingInfo
        ' 
        cardReadingInfo.Controls.Add(lblReadingInfoTitle)
        cardReadingInfo.Controls.Add(lblReadingInfoBody)
        cardReadingInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cardReadingInfo.FillColor = Color.White
        cardReadingInfo.GradFrom = Color.FromArgb(232, 154, 60)
        cardReadingInfo.GradTo = Color.FromArgb(184, 80, 66)
        cardReadingInfo.Location = New Point(540, 20)
        cardReadingInfo.Radius = 18
        cardReadingInfo.Size = New Size(370, 392)
        cardReadingInfo.Name = "cardReadingInfo"
        cardReadingInfo.TabIndex = 1
        ' 
        ' lblReadingInfoTitle
        ' 
        lblReadingInfoTitle.AutoSize = True
        lblReadingInfoTitle.BackColor = Color.Transparent
        lblReadingInfoTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblReadingInfoTitle.ForeColor = Color.White
        lblReadingInfoTitle.Location = New Point(24, 22)
        lblReadingInfoTitle.Text = "How it works"
        lblReadingInfoTitle.Name = "lblReadingInfoTitle"
        lblReadingInfoTitle.TabIndex = 0
        ' 
        ' lblReadingInfoBody
        ' 
        lblReadingInfoBody.AutoSize = True
        lblReadingInfoBody.BackColor = Color.Transparent
        lblReadingInfoBody.Font = New Font("Segoe UI", 10.5F)
        lblReadingInfoBody.ForeColor = Color.White
        lblReadingInfoBody.Location = New Point(24, 62)
        lblReadingInfoBody.MaximumSize = New Size(318, 0)
        lblReadingInfoBody.Text = "1. Read the units left on your prepaid meter." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Enter the previous reading and the current one." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Add your average daily usage and we estimate how many days your units will last." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your dashboard updates instantly and the entry is saved to Usage Reports."
        lblReadingInfoBody.Name = "lblReadingInfoBody"
        lblReadingInfoBody.TabIndex = 1
        ' 
        ' cardTopUpForm
        ' 
        cardTopUpForm.Controls.Add(lblTopUpTitle)
        cardTopUpForm.Controls.Add(lblTopUpSub)
        cardTopUpForm.Controls.Add(lblUnitsCaption)
        cardTopUpForm.Controls.Add(pnlUnitsField)
        cardTopUpForm.Controls.Add(lblAmountCaption)
        cardTopUpForm.Controls.Add(pnlAmountField)
        cardTopUpForm.Controls.Add(btnRecordTopUp)
        cardTopUpForm.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardTopUpForm.FillColor = Color.White
        cardTopUpForm.Location = New Point(20, 20)
        cardTopUpForm.Radius = 18
        cardTopUpForm.Size = New Size(500, 318)
        cardTopUpForm.Name = "cardTopUpForm"
        cardTopUpForm.TabIndex = 0
        ' 
        ' lblTopUpTitle
        ' 
        lblTopUpTitle.AutoSize = True
        lblTopUpTitle.BackColor = Color.Transparent
        lblTopUpTitle.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        lblTopUpTitle.ForeColor = Color.FromArgb(58, 42, 38)
        lblTopUpTitle.Location = New Point(28, 22)
        lblTopUpTitle.Text = "💳 Record a Top-Up"
        lblTopUpTitle.Name = "lblTopUpTitle"
        lblTopUpTitle.TabIndex = 0
        ' 
        ' lblTopUpSub
        ' 
        lblTopUpSub.AutoSize = True
        lblTopUpSub.BackColor = Color.Transparent
        lblTopUpSub.Font = New Font("Segoe UI", 10F)
        lblTopUpSub.ForeColor = Color.FromArgb(138, 115, 108)
        lblTopUpSub.Location = New Point(30, 58)
        lblTopUpSub.Text = "Add units you have just bought."
        lblTopUpSub.Name = "lblTopUpSub"
        lblTopUpSub.TabIndex = 1
        ' 
        ' lblUnitsCaption
        ' 
        lblUnitsCaption.AutoSize = True
        lblUnitsCaption.BackColor = Color.Transparent
        lblUnitsCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblUnitsCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblUnitsCaption.Location = New Point(28, 98)
        lblUnitsCaption.Text = "Units purchased (kWh)"
        lblUnitsCaption.Name = "lblUnitsCaption"
        lblUnitsCaption.TabIndex = 2
        ' 
        ' pnlUnitsField
        ' 
        pnlUnitsField.Controls.Add(txtTopUpUnits)
        pnlUnitsField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlUnitsField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlUnitsField.FillColor = Color.White
        pnlUnitsField.Location = New Point(28, 122)
        pnlUnitsField.Radius = 10
        pnlUnitsField.Shadow = False
        pnlUnitsField.Size = New Size(444, 40)
        pnlUnitsField.Name = "pnlUnitsField"
        pnlUnitsField.TabIndex = 3
        ' 
        ' txtTopUpUnits
        ' 
        txtTopUpUnits.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTopUpUnits.BackColor = Color.White
        txtTopUpUnits.BorderStyle = BorderStyle.None
        txtTopUpUnits.Font = New Font("Segoe UI", 12F)
        txtTopUpUnits.Location = New Point(14, 8)
        txtTopUpUnits.Size = New Size(416, 23)
        txtTopUpUnits.Name = "txtTopUpUnits"
        txtTopUpUnits.TabIndex = 0
        ' 
        ' lblAmountCaption
        ' 
        lblAmountCaption.AutoSize = True
        lblAmountCaption.BackColor = Color.Transparent
        lblAmountCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblAmountCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblAmountCaption.Location = New Point(28, 174)
        lblAmountCaption.Text = "Amount paid (GH₵)"
        lblAmountCaption.Name = "lblAmountCaption"
        lblAmountCaption.TabIndex = 4
        ' 
        ' pnlAmountField
        ' 
        pnlAmountField.Controls.Add(txtAmountPaid)
        pnlAmountField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlAmountField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlAmountField.FillColor = Color.White
        pnlAmountField.Location = New Point(28, 198)
        pnlAmountField.Radius = 10
        pnlAmountField.Shadow = False
        pnlAmountField.Size = New Size(444, 40)
        pnlAmountField.Name = "pnlAmountField"
        pnlAmountField.TabIndex = 5
        ' 
        ' txtAmountPaid
        ' 
        txtAmountPaid.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtAmountPaid.BackColor = Color.White
        txtAmountPaid.BorderStyle = BorderStyle.None
        txtAmountPaid.Font = New Font("Segoe UI", 12F)
        txtAmountPaid.Location = New Point(14, 8)
        txtAmountPaid.Size = New Size(416, 23)
        txtAmountPaid.Name = "txtAmountPaid"
        txtAmountPaid.TabIndex = 0
        ' 
        ' btnRecordTopUp
        ' 
        btnRecordTopUp.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnRecordTopUp.BackColor = Color.FromArgb(184, 80, 66)
        btnRecordTopUp.Cursor = Cursors.Hand
        btnRecordTopUp.FlatAppearance.BorderSize = 0
        btnRecordTopUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 42, 38)
        btnRecordTopUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 63, 51)
        btnRecordTopUp.FlatStyle = FlatStyle.Flat
        btnRecordTopUp.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnRecordTopUp.ForeColor = Color.White
        btnRecordTopUp.Location = New Point(28, 254)
        btnRecordTopUp.Size = New Size(444, 46)
        btnRecordTopUp.Text = "💳  Record Top-Up"
        btnRecordTopUp.UseVisualStyleBackColor = False
        btnRecordTopUp.Name = "btnRecordTopUp"
        btnRecordTopUp.TabIndex = 6
        ' 
        ' cardTopUpInfo
        ' 
        cardTopUpInfo.Controls.Add(lblTopUpInfoTitle)
        cardTopUpInfo.Controls.Add(lblTopUpInfoBody)
        cardTopUpInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cardTopUpInfo.FillColor = Color.White
        cardTopUpInfo.GradFrom = Color.FromArgb(91, 140, 58)
        cardTopUpInfo.GradTo = Color.FromArgb(38, 70, 83)
        cardTopUpInfo.Location = New Point(540, 20)
        cardTopUpInfo.Radius = 18
        cardTopUpInfo.Size = New Size(370, 318)
        cardTopUpInfo.Name = "cardTopUpInfo"
        cardTopUpInfo.TabIndex = 1
        ' 
        ' lblTopUpInfoTitle
        ' 
        lblTopUpInfoTitle.AutoSize = True
        lblTopUpInfoTitle.BackColor = Color.Transparent
        lblTopUpInfoTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTopUpInfoTitle.ForeColor = Color.White
        lblTopUpInfoTitle.Location = New Point(24, 22)
        lblTopUpInfoTitle.Text = "Why record top-ups?"
        lblTopUpInfoTitle.Name = "lblTopUpInfoTitle"
        lblTopUpInfoTitle.TabIndex = 0
        ' 
        ' lblTopUpInfoBody
        ' 
        lblTopUpInfoBody.AutoSize = True
        lblTopUpInfoBody.BackColor = Color.Transparent
        lblTopUpInfoBody.Font = New Font("Segoe UI", 10.5F)
        lblTopUpInfoBody.ForeColor = Color.White
        lblTopUpInfoBody.Location = New Point(24, 62)
        lblTopUpInfoBody.MaximumSize = New Size(318, 0)
        lblTopUpInfoBody.Text = "Every top-up raises your unit balance and shows as your latest top-up on the dashboard." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keeping the amount you paid lets you see how much you spend over time in Usage Reports."
        lblTopUpInfoBody.Name = "lblTopUpInfoBody"
        lblTopUpInfoBody.TabIndex = 1
        ' 
        ' cardPlanner
        ' 
        cardPlanner.Controls.Add(lblPlannerTitle)
        cardPlanner.Controls.Add(lblPlannerSub)
        cardPlanner.Controls.Add(lblNameCaption)
        cardPlanner.Controls.Add(pnlNameField)
        cardPlanner.Controls.Add(lblWattsCaption)
        cardPlanner.Controls.Add(pnlWattsField)
        cardPlanner.Controls.Add(lblHoursCaption)
        cardPlanner.Controls.Add(pnlHoursField)
        cardPlanner.Controls.Add(btnCalculateAppliance)
        cardPlanner.Controls.Add(btnClearAppliance)
        cardPlanner.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardPlanner.FillColor = Color.White
        cardPlanner.Location = New Point(20, 20)
        cardPlanner.Radius = 18
        cardPlanner.Size = New Size(500, 392)
        cardPlanner.Name = "cardPlanner"
        cardPlanner.TabIndex = 0
        ' 
        ' lblPlannerTitle
        ' 
        lblPlannerTitle.AutoSize = True
        lblPlannerTitle.BackColor = Color.Transparent
        lblPlannerTitle.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        lblPlannerTitle.ForeColor = Color.FromArgb(58, 42, 38)
        lblPlannerTitle.Location = New Point(28, 22)
        lblPlannerTitle.Text = "🔌 Appliance Planner"
        lblPlannerTitle.Name = "lblPlannerTitle"
        lblPlannerTitle.TabIndex = 0
        ' 
        ' lblPlannerSub
        ' 
        lblPlannerSub.AutoSize = True
        lblPlannerSub.BackColor = Color.Transparent
        lblPlannerSub.Font = New Font("Segoe UI", 10F)
        lblPlannerSub.ForeColor = Color.FromArgb(138, 115, 108)
        lblPlannerSub.Location = New Point(30, 58)
        lblPlannerSub.Text = "Find out how many units an appliance uses."
        lblPlannerSub.Name = "lblPlannerSub"
        lblPlannerSub.TabIndex = 1
        ' 
        ' lblNameCaption
        ' 
        lblNameCaption.AutoSize = True
        lblNameCaption.BackColor = Color.Transparent
        lblNameCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblNameCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblNameCaption.Location = New Point(28, 98)
        lblNameCaption.Text = "Appliance name"
        lblNameCaption.Name = "lblNameCaption"
        lblNameCaption.TabIndex = 2
        ' 
        ' pnlNameField
        ' 
        pnlNameField.Controls.Add(txtApplianceName)
        pnlNameField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlNameField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlNameField.FillColor = Color.White
        pnlNameField.Location = New Point(28, 122)
        pnlNameField.Radius = 10
        pnlNameField.Shadow = False
        pnlNameField.Size = New Size(444, 40)
        pnlNameField.Name = "pnlNameField"
        pnlNameField.TabIndex = 3
        ' 
        ' txtApplianceName
        ' 
        txtApplianceName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtApplianceName.BackColor = Color.White
        txtApplianceName.BorderStyle = BorderStyle.None
        txtApplianceName.Font = New Font("Segoe UI", 12F)
        txtApplianceName.Location = New Point(14, 8)
        txtApplianceName.Size = New Size(416, 23)
        txtApplianceName.Name = "txtApplianceName"
        txtApplianceName.TabIndex = 0
        ' 
        ' lblWattsCaption
        ' 
        lblWattsCaption.AutoSize = True
        lblWattsCaption.BackColor = Color.Transparent
        lblWattsCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblWattsCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblWattsCaption.Location = New Point(28, 174)
        lblWattsCaption.Text = "Power rating (Watts)"
        lblWattsCaption.Name = "lblWattsCaption"
        lblWattsCaption.TabIndex = 4
        ' 
        ' pnlWattsField
        ' 
        pnlWattsField.Controls.Add(txtWattage)
        pnlWattsField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlWattsField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlWattsField.FillColor = Color.White
        pnlWattsField.Location = New Point(28, 198)
        pnlWattsField.Radius = 10
        pnlWattsField.Shadow = False
        pnlWattsField.Size = New Size(444, 40)
        pnlWattsField.Name = "pnlWattsField"
        pnlWattsField.TabIndex = 5
        ' 
        ' txtWattage
        ' 
        txtWattage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtWattage.BackColor = Color.White
        txtWattage.BorderStyle = BorderStyle.None
        txtWattage.Font = New Font("Segoe UI", 12F)
        txtWattage.Location = New Point(14, 8)
        txtWattage.Size = New Size(416, 23)
        txtWattage.Name = "txtWattage"
        txtWattage.TabIndex = 0
        ' 
        ' lblHoursCaption
        ' 
        lblHoursCaption.AutoSize = True
        lblHoursCaption.BackColor = Color.Transparent
        lblHoursCaption.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblHoursCaption.ForeColor = Color.FromArgb(58, 42, 38)
        lblHoursCaption.Location = New Point(28, 250)
        lblHoursCaption.Text = "Hours used per day"
        lblHoursCaption.Name = "lblHoursCaption"
        lblHoursCaption.TabIndex = 6
        ' 
        ' pnlHoursField
        ' 
        pnlHoursField.Controls.Add(txtHours)
        pnlHoursField.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHoursField.BorderColor = Color.FromArgb(230, 205, 195)
        pnlHoursField.FillColor = Color.White
        pnlHoursField.Location = New Point(28, 274)
        pnlHoursField.Radius = 10
        pnlHoursField.Shadow = False
        pnlHoursField.Size = New Size(444, 40)
        pnlHoursField.Name = "pnlHoursField"
        pnlHoursField.TabIndex = 7
        ' 
        ' txtHours
        ' 
        txtHours.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtHours.BackColor = Color.White
        txtHours.BorderStyle = BorderStyle.None
        txtHours.Font = New Font("Segoe UI", 12F)
        txtHours.Location = New Point(14, 8)
        txtHours.Size = New Size(416, 23)
        txtHours.Name = "txtHours"
        txtHours.TabIndex = 0
        ' 
        ' btnCalculateAppliance
        ' 
        btnCalculateAppliance.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnCalculateAppliance.BackColor = Color.FromArgb(184, 80, 66)
        btnCalculateAppliance.Cursor = Cursors.Hand
        btnCalculateAppliance.FlatAppearance.BorderSize = 0
        btnCalculateAppliance.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 42, 38)
        btnCalculateAppliance.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 63, 51)
        btnCalculateAppliance.FlatStyle = FlatStyle.Flat
        btnCalculateAppliance.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnCalculateAppliance.ForeColor = Color.White
        btnCalculateAppliance.Location = New Point(28, 330)
        btnCalculateAppliance.Size = New Size(300, 46)
        btnCalculateAppliance.Text = "🧮  Calculate Appliance"
        btnCalculateAppliance.UseVisualStyleBackColor = False
        btnCalculateAppliance.Name = "btnCalculateAppliance"
        btnCalculateAppliance.TabIndex = 8
        ' 
        ' btnClearAppliance
        ' 
        btnClearAppliance.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnClearAppliance.BackColor = Color.White
        btnClearAppliance.Cursor = Cursors.Hand
        btnClearAppliance.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnClearAppliance.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 241, 236)
        btnClearAppliance.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 241, 236)
        btnClearAppliance.FlatStyle = FlatStyle.Flat
        btnClearAppliance.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnClearAppliance.ForeColor = Color.FromArgb(184, 80, 66)
        btnClearAppliance.Location = New Point(342, 330)
        btnClearAppliance.Size = New Size(130, 46)
        btnClearAppliance.Text = "🧹  Clear"
        btnClearAppliance.UseVisualStyleBackColor = False
        btnClearAppliance.Name = "btnClearAppliance"
        btnClearAppliance.TabIndex = 9
        ' 
        ' cardResult
        ' 
        cardResult.Controls.Add(lblResultTitle)
        cardResult.Controls.Add(lblApplianceResult)
        cardResult.Controls.Add(lblPlannerHint)
        cardResult.Controls.Add(btnApplOpen)
        cardResult.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardResult.FillColor = Color.White
        cardResult.GradFrom = Color.FromArgb(42, 157, 143)
        cardResult.GradTo = Color.FromArgb(38, 70, 83)
        cardResult.Location = New Point(540, 20)
        cardResult.Radius = 18
        cardResult.Size = New Size(370, 252)
        cardResult.Name = "cardResult"
        cardResult.TabIndex = 1
        ' 
        ' lblResultTitle
        ' 
        lblResultTitle.AutoSize = True
        lblResultTitle.BackColor = Color.Transparent
        lblResultTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblResultTitle.ForeColor = Color.White
        lblResultTitle.Location = New Point(24, 20)
        lblResultTitle.Text = "📋 Result"
        lblResultTitle.Name = "lblResultTitle"
        lblResultTitle.TabIndex = 0
        ' 
        ' lblApplianceResult
        ' 
        lblApplianceResult.AutoSize = True
        lblApplianceResult.BackColor = Color.Transparent
        lblApplianceResult.Font = New Font("Segoe UI", 11.5F)
        lblApplianceResult.ForeColor = Color.White
        lblApplianceResult.Location = New Point(24, 60)
        lblApplianceResult.MaximumSize = New Size(318, 0)
        lblApplianceResult.Text = "Your appliance's daily and monthly consumption will appear here."
        lblApplianceResult.Name = "lblApplianceResult"
        lblApplianceResult.TabIndex = 1
        ' 
        ' lblPlannerHint
        ' 
        lblPlannerHint.AutoSize = True
        lblPlannerHint.BackColor = Color.Transparent
        lblPlannerHint.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPlannerHint.ForeColor = Color.FromArgb(255, 255, 224, 160)
        lblPlannerHint.Location = New Point(24, 150)
        lblPlannerHint.Text = ""
        lblPlannerHint.Name = "lblPlannerHint"
        lblPlannerHint.TabIndex = 2
        ' 
        ' btnApplOpen
        ' 
        btnApplOpen.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnApplOpen.BackColor = Color.White
        btnApplOpen.Cursor = Cursors.Hand
        btnApplOpen.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnApplOpen.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 241, 236)
        btnApplOpen.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 241, 236)
        btnApplOpen.FlatStyle = FlatStyle.Flat
        btnApplOpen.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnApplOpen.ForeColor = Color.FromArgb(184, 80, 66)
        btnApplOpen.Location = New Point(24, 192)
        btnApplOpen.Size = New Size(322, 42)
        btnApplOpen.Text = "View Appliance Planner Reports  →"
        btnApplOpen.UseVisualStyleBackColor = False
        btnApplOpen.Name = "btnApplOpen"
        btnApplOpen.TabIndex = 3
        ' 
        ' cardHowCalc
        ' 
        cardHowCalc.Controls.Add(lblHowCalcTitle)
        cardHowCalc.Controls.Add(lblHowCalcBody)
        cardHowCalc.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardHowCalc.FillColor = Color.White
        cardHowCalc.GradFrom = Color.FromArgb(232, 154, 60)
        cardHowCalc.GradTo = Color.FromArgb(184, 80, 66)
        cardHowCalc.Location = New Point(540, 288)
        cardHowCalc.Radius = 18
        cardHowCalc.Size = New Size(370, 124)
        cardHowCalc.Name = "cardHowCalc"
        cardHowCalc.TabIndex = 2
        ' 
        ' lblHowCalcTitle
        ' 
        lblHowCalcTitle.AutoSize = True
        lblHowCalcTitle.BackColor = Color.Transparent
        lblHowCalcTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblHowCalcTitle.ForeColor = Color.White
        lblHowCalcTitle.Location = New Point(24, 22)
        lblHowCalcTitle.Text = "How it is calculated"
        lblHowCalcTitle.Name = "lblHowCalcTitle"
        lblHowCalcTitle.TabIndex = 0
        ' 
        ' lblHowCalcBody
        ' 
        lblHowCalcBody.AutoSize = True
        lblHowCalcBody.BackColor = Color.Transparent
        lblHowCalcBody.Font = New Font("Segoe UI", 10.5F)
        lblHowCalcBody.ForeColor = Color.White
        lblHowCalcBody.Location = New Point(24, 62)
        lblHowCalcBody.MaximumSize = New Size(318, 0)
        lblHowCalcBody.Text = "Watts × hours ÷ 1000 = kWh per day. The monthly figure assumes 30 days."
        lblHowCalcBody.Name = "lblHowCalcBody"
        lblHowCalcBody.TabIndex = 1
        ' 
        ' cardApplReports
        ' 
        cardApplReports.Controls.Add(lblApplReportsTitle)
        cardApplReports.Controls.Add(lblApplReportsSub)
        cardApplReports.Controls.Add(btnApplPdf)
        cardApplReports.Controls.Add(btnApplCsv)
        cardApplReports.Controls.Add(btnApplClear)
        cardApplReports.Controls.Add(dgvAppliances)
        cardApplReports.Controls.Add(lblApplTotals)
        cardApplReports.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cardApplReports.FillColor = Color.White
        cardApplReports.Location = New Point(20, 20)
        cardApplReports.Radius = 18
        cardApplReports.Size = New Size(890, 636)
        cardApplReports.Name = "cardApplReports"
        cardApplReports.TabIndex = 0
        ' 
        ' lblApplReportsTitle
        ' 
        lblApplReportsTitle.AutoSize = True
        lblApplReportsTitle.BackColor = Color.Transparent
        lblApplReportsTitle.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        lblApplReportsTitle.ForeColor = Color.FromArgb(58, 42, 38)
        lblApplReportsTitle.Location = New Point(26, 20)
        lblApplReportsTitle.Text = "🧾 Appliance Planner Reports"
        lblApplReportsTitle.Name = "lblApplReportsTitle"
        lblApplReportsTitle.TabIndex = 0
        ' 
        ' lblApplReportsSub
        ' 
        lblApplReportsSub.AutoSize = True
        lblApplReportsSub.BackColor = Color.Transparent
        lblApplReportsSub.Font = New Font("Segoe UI", 10F)
        lblApplReportsSub.ForeColor = Color.FromArgb(138, 115, 108)
        lblApplReportsSub.Location = New Point(28, 64)
        lblApplReportsSub.Text = "Every appliance you calculate in the Appliance Planner is saved here."
        lblApplReportsSub.Name = "lblApplReportsSub"
        lblApplReportsSub.TabIndex = 1
        ' 
        ' btnApplPdf
        ' 
        btnApplPdf.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnApplPdf.BackColor = Color.FromArgb(184, 80, 66)
        btnApplPdf.Cursor = Cursors.Hand
        btnApplPdf.FlatAppearance.BorderSize = 0
        btnApplPdf.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 42, 38)
        btnApplPdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 63, 51)
        btnApplPdf.FlatStyle = FlatStyle.Flat
        btnApplPdf.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnApplPdf.ForeColor = Color.White
        btnApplPdf.Location = New Point(736, 20)
        btnApplPdf.Size = New Size(130, 38)
        btnApplPdf.Text = "Export PDF"
        btnApplPdf.UseVisualStyleBackColor = False
        btnApplPdf.Name = "btnApplPdf"
        btnApplPdf.TabIndex = 2
        ' 
        ' btnApplCsv
        ' 
        btnApplCsv.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnApplCsv.BackColor = Color.White
        btnApplCsv.Cursor = Cursors.Hand
        btnApplCsv.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnApplCsv.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 241, 236)
        btnApplCsv.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 241, 236)
        btnApplCsv.FlatStyle = FlatStyle.Flat
        btnApplCsv.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnApplCsv.ForeColor = Color.FromArgb(184, 80, 66)
        btnApplCsv.Location = New Point(596, 20)
        btnApplCsv.Size = New Size(130, 38)
        btnApplCsv.Text = "Export CSV"
        btnApplCsv.UseVisualStyleBackColor = False
        btnApplCsv.Name = "btnApplCsv"
        btnApplCsv.TabIndex = 3
        ' 
        ' btnApplClear
        ' 
        btnApplClear.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnApplClear.BackColor = Color.White
        btnApplClear.Cursor = Cursors.Hand
        btnApplClear.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnApplClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 241, 236)
        btnApplClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 241, 236)
        btnApplClear.FlatStyle = FlatStyle.Flat
        btnApplClear.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnApplClear.ForeColor = Color.FromArgb(184, 80, 66)
        btnApplClear.Location = New Point(486, 20)
        btnApplClear.Size = New Size(100, 38)
        btnApplClear.Text = "Clear"
        btnApplClear.UseVisualStyleBackColor = False
        btnApplClear.Name = "btnApplClear"
        btnApplClear.TabIndex = 4
        ' 
        ' dgvAppliances
        ' 
        dgvAppliances.AllowUserToAddRows = False
        dgvAppliances.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = Color.FromArgb(251, 241, 236)
        dgvAppliances.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        dgvAppliances.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAppliances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAppliances.BackgroundColor = Color.White
        dgvAppliances.BorderStyle = BorderStyle.None
        dgvAppliances.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAppliances.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(184, 80, 66)
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(184, 80, 66)
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvAppliances.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvAppliances.ColumnHeadersHeight = 40
        dgvAppliances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAppliances.Columns.AddRange(New DataGridViewColumn() {colApplDate, colApplName, colApplPower, colApplHours, colApplDaily, colApplMonthly})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(58, 42, 38)
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(243, 211, 201)
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(58, 42, 38)
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvAppliances.DefaultCellStyle = DataGridViewCellStyle5
        dgvAppliances.EnableHeadersVisualStyles = False
        dgvAppliances.GridColor = Color.FromArgb(240, 225, 218)
        dgvAppliances.Location = New Point(24, 104)
        dgvAppliances.Name = "dgvAppliances"
        dgvAppliances.ReadOnly = True
        dgvAppliances.RowHeadersVisible = False
        dgvAppliances.RowTemplate.Height = 36
        dgvAppliances.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAppliances.Size = New Size(842, 470)
        dgvAppliances.TabIndex = 5
        ' 
        ' colApplDate
        ' 
        colApplDate.HeaderText = "Date"
        colApplDate.Name = "colApplDate"
        ' 
        ' colApplName
        ' 
        colApplName.HeaderText = "Appliance"
        colApplName.Name = "colApplName"
        ' 
        ' colApplPower
        ' 
        colApplPower.HeaderText = "Power (W)"
        colApplPower.Name = "colApplPower"
        ' 
        ' colApplHours
        ' 
        colApplHours.HeaderText = "Hours / day"
        colApplHours.Name = "colApplHours"
        ' 
        ' colApplDaily
        ' 
        colApplDaily.HeaderText = "Daily (kWh)"
        colApplDaily.Name = "colApplDaily"
        ' 
        ' colApplMonthly
        ' 
        colApplMonthly.HeaderText = "Monthly (kWh)"
        colApplMonthly.Name = "colApplMonthly"
        ' 
        ' lblApplTotals
        ' 
        lblApplTotals.AutoSize = True
        lblApplTotals.BackColor = Color.Transparent
        lblApplTotals.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblApplTotals.ForeColor = Color.FromArgb(58, 42, 38)
        lblApplTotals.Location = New Point(26, 584)
        lblApplTotals.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblApplTotals.Text = "🔌 0 appliances   ·   ⚡ 0.00 kWh per day   ·   📅 0.00 kWh per month"
        lblApplTotals.Name = "lblApplTotals"
        lblApplTotals.TabIndex = 6
        ' 
        ' cardUsageReports
        ' 
        cardUsageReports.Controls.Add(lblUsageReportsTitle)
        cardUsageReports.Controls.Add(lblUsageReportsSub)
        cardUsageReports.Controls.Add(btnExportPdf)
        cardUsageReports.Controls.Add(btnExportCsv)
        cardUsageReports.Controls.Add(btnRefreshReports)
        cardUsageReports.Controls.Add(dgvUsageHistory)
        cardUsageReports.Controls.Add(lblUsageTotals)
        cardUsageReports.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cardUsageReports.FillColor = Color.White
        cardUsageReports.Location = New Point(20, 20)
        cardUsageReports.Radius = 18
        cardUsageReports.Size = New Size(890, 636)
        cardUsageReports.Name = "cardUsageReports"
        cardUsageReports.TabIndex = 0
        ' 
        ' lblUsageReportsTitle
        ' 
        lblUsageReportsTitle.AutoSize = True
        lblUsageReportsTitle.BackColor = Color.Transparent
        lblUsageReportsTitle.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        lblUsageReportsTitle.ForeColor = Color.FromArgb(58, 42, 38)
        lblUsageReportsTitle.Location = New Point(26, 20)
        lblUsageReportsTitle.Text = "📈 Usage Reports"
        lblUsageReportsTitle.Name = "lblUsageReportsTitle"
        lblUsageReportsTitle.TabIndex = 0
        ' 
        ' lblUsageReportsSub
        ' 
        lblUsageReportsSub.AutoSize = True
        lblUsageReportsSub.BackColor = Color.Transparent
        lblUsageReportsSub.Font = New Font("Segoe UI", 10F)
        lblUsageReportsSub.ForeColor = Color.FromArgb(138, 115, 108)
        lblUsageReportsSub.Location = New Point(28, 64)
        lblUsageReportsSub.Text = "Your meter readings and top-ups, saved automatically."
        lblUsageReportsSub.Name = "lblUsageReportsSub"
        lblUsageReportsSub.TabIndex = 1
        ' 
        ' btnExportPdf
        ' 
        btnExportPdf.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExportPdf.BackColor = Color.FromArgb(184, 80, 66)
        btnExportPdf.Cursor = Cursors.Hand
        btnExportPdf.FlatAppearance.BorderSize = 0
        btnExportPdf.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 42, 38)
        btnExportPdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 63, 51)
        btnExportPdf.FlatStyle = FlatStyle.Flat
        btnExportPdf.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnExportPdf.ForeColor = Color.White
        btnExportPdf.Location = New Point(736, 20)
        btnExportPdf.Size = New Size(130, 38)
        btnExportPdf.Text = "Export PDF"
        btnExportPdf.UseVisualStyleBackColor = False
        btnExportPdf.Name = "btnExportPdf"
        btnExportPdf.TabIndex = 2
        ' 
        ' btnExportCsv
        ' 
        btnExportCsv.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExportCsv.BackColor = Color.White
        btnExportCsv.Cursor = Cursors.Hand
        btnExportCsv.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnExportCsv.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 241, 236)
        btnExportCsv.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 241, 236)
        btnExportCsv.FlatStyle = FlatStyle.Flat
        btnExportCsv.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnExportCsv.ForeColor = Color.FromArgb(184, 80, 66)
        btnExportCsv.Location = New Point(596, 20)
        btnExportCsv.Size = New Size(130, 38)
        btnExportCsv.Text = "Export CSV"
        btnExportCsv.UseVisualStyleBackColor = False
        btnExportCsv.Name = "btnExportCsv"
        btnExportCsv.TabIndex = 3
        ' 
        ' btnRefreshReports
        ' 
        btnRefreshReports.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefreshReports.BackColor = Color.White
        btnRefreshReports.Cursor = Cursors.Hand
        btnRefreshReports.FlatAppearance.BorderColor = Color.FromArgb(184, 80, 66)
        btnRefreshReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 241, 236)
        btnRefreshReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 241, 236)
        btnRefreshReports.FlatStyle = FlatStyle.Flat
        btnRefreshReports.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnRefreshReports.ForeColor = Color.FromArgb(184, 80, 66)
        btnRefreshReports.Location = New Point(466, 20)
        btnRefreshReports.Size = New Size(120, 38)
        btnRefreshReports.Text = "↻  Refresh"
        btnRefreshReports.UseVisualStyleBackColor = False
        btnRefreshReports.Name = "btnRefreshReports"
        btnRefreshReports.TabIndex = 4
        ' 
        ' dgvUsageHistory
        ' 
        dgvUsageHistory.AllowUserToAddRows = False
        dgvUsageHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = Color.FromArgb(251, 241, 236)
        dgvUsageHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        dgvUsageHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsageHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsageHistory.BackgroundColor = Color.White
        dgvUsageHistory.BorderStyle = BorderStyle.None
        dgvUsageHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUsageHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(184, 80, 66)
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 80, 66)
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsageHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsageHistory.ColumnHeadersHeight = 40
        dgvUsageHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvUsageHistory.Columns.AddRange(New DataGridViewColumn() {colDate, colType, colUnits, colAmount, colBalance})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(58, 42, 38)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 211, 201)
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(58, 42, 38)
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsageHistory.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsageHistory.EnableHeadersVisualStyles = False
        dgvUsageHistory.GridColor = Color.FromArgb(240, 225, 218)
        dgvUsageHistory.Location = New Point(24, 104)
        dgvUsageHistory.Name = "dgvUsageHistory"
        dgvUsageHistory.ReadOnly = True
        dgvUsageHistory.RowHeadersVisible = False
        dgvUsageHistory.RowTemplate.Height = 36
        dgvUsageHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsageHistory.Size = New Size(842, 470)
        dgvUsageHistory.TabIndex = 5
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.Name = "colDate"
        ' 
        ' colType
        ' 
        colType.HeaderText = "Transaction"
        colType.Name = "colType"
        ' 
        ' colUnits
        ' 
        colUnits.HeaderText = "Units (kWh)"
        colUnits.Name = "colUnits"
        ' 
        ' colAmount
        ' 
        colAmount.HeaderText = "Amount (GH₵)"
        colAmount.Name = "colAmount"
        ' 
        ' colBalance
        ' 
        colBalance.HeaderText = "Balance (kWh)"
        colBalance.Name = "colBalance"
        ' 
        ' lblUsageTotals
        ' 
        lblUsageTotals.AutoSize = True
        lblUsageTotals.BackColor = Color.Transparent
        lblUsageTotals.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblUsageTotals.ForeColor = Color.FromArgb(58, 42, 38)
        lblUsageTotals.Location = New Point(26, 584)
        lblUsageTotals.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblUsageTotals.Text = "🧾 0 transactions   ·   ⚡ 0.00 kWh used   ·   💰 GH₵ 0.00 spent on top-ups"
        lblUsageTotals.Name = "lblUsageTotals"
        lblUsageTotals.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(247, 239, 233)
        ClientSize = New Size(1180, 740)
        Controls.Add(pnlDashboard)
        Controls.Add(pnlReading)
        Controls.Add(pnlTopUp)
        Controls.Add(pnlPlanner)
        Controls.Add(pnlPlannerReports)
        Controls.Add(pnlReports)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 10F)
        MinimumSize = New Size(1100, 700)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PowerWise - Electricity Tracker"
        cardUsageReports.ResumeLayout(False)
        cardApplReports.ResumeLayout(False)
        cardHowCalc.ResumeLayout(False)
        cardResult.ResumeLayout(False)
        pnlHoursField.ResumeLayout(False)
        pnlWattsField.ResumeLayout(False)
        pnlNameField.ResumeLayout(False)
        cardPlanner.ResumeLayout(False)
        cardTopUpInfo.ResumeLayout(False)
        pnlAmountField.ResumeLayout(False)
        pnlUnitsField.ResumeLayout(False)
        cardTopUpForm.ResumeLayout(False)
        cardReadingInfo.ResumeLayout(False)
        pnlDailyField.ResumeLayout(False)
        pnlCurrentField.ResumeLayout(False)
        pnlPreviousField.ResumeLayout(False)
        cardReading.ResumeLayout(False)
        cardTip.ResumeLayout(False)
        cardRecent.ResumeLayout(False)
        cardTopUp.ResumeLayout(False)
        cardDays.ResumeLayout(False)
        cardDaily.ResumeLayout(False)
        cardUnits.ResumeLayout(False)
        cardBanner.ResumeLayout(False)
        pnlReports.ResumeLayout(False)
        pnlPlannerReports.ResumeLayout(False)
        pnlPlanner.ResumeLayout(False)
        pnlTopUp.ResumeLayout(False)
        pnlReading.ResumeLayout(False)
        pnlDashboard.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        CType(dgvUsageHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAppliances, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWho As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnReading As Button
    Friend WithEvents btnTopup As Button
    Friend WithEvents btnAppliances As Button
    Friend WithEvents btnApplReports As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlReading As Panel
    Friend WithEvents pnlTopUp As Panel
    Friend WithEvents pnlPlanner As Panel
    Friend WithEvents pnlPlannerReports As Panel
    Friend WithEvents pnlReports As Panel
    Friend WithEvents cardBanner As RoundPanel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblAlert As Label
    Friend WithEvents lblBolt As Label
    Friend WithEvents cardUnits As RoundPanel
    Friend WithEvents lblIcon1 As Label
    Friend WithEvents lblUnitsHeading As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents cardDaily As RoundPanel
    Friend WithEvents lblIcon2 As Label
    Friend WithEvents lblDailyHeading As Label
    Friend WithEvents lblDailyUsage As Label
    Friend WithEvents cardDays As RoundPanel
    Friend WithEvents lblIcon3 As Label
    Friend WithEvents lblDaysHeading As Label
    Friend WithEvents lblDaysLeft As Label
    Friend WithEvents cardTopUp As RoundPanel
    Friend WithEvents lblIcon4 As Label
    Friend WithEvents lblTopUpHeading As Label
    Friend WithEvents lblLatestTopUp As Label
    Friend WithEvents cardRecent As RoundPanel
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents lblRecent As Label
    Friend WithEvents cardTip As RoundPanel
    Friend WithEvents lblTipTitle As Label
    Friend WithEvents lblTip As Label
    Friend WithEvents cardReading As RoundPanel
    Friend WithEvents lblReadingTitle As Label
    Friend WithEvents lblReadingSub As Label
    Friend WithEvents lblPreviousCaption As Label
    Friend WithEvents pnlPreviousField As RoundPanel
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents lblCurrentCaption As Label
    Friend WithEvents pnlCurrentField As RoundPanel
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents lblDailyCaption As Label
    Friend WithEvents pnlDailyField As RoundPanel
    Friend WithEvents txtDaily As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClearReading As Button
    Friend WithEvents cardReadingInfo As RoundPanel
    Friend WithEvents lblReadingInfoTitle As Label
    Friend WithEvents lblReadingInfoBody As Label
    Friend WithEvents cardTopUpForm As RoundPanel
    Friend WithEvents lblTopUpTitle As Label
    Friend WithEvents lblTopUpSub As Label
    Friend WithEvents lblUnitsCaption As Label
    Friend WithEvents pnlUnitsField As RoundPanel
    Friend WithEvents txtTopUpUnits As TextBox
    Friend WithEvents lblAmountCaption As Label
    Friend WithEvents pnlAmountField As RoundPanel
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents btnRecordTopUp As Button
    Friend WithEvents cardTopUpInfo As RoundPanel
    Friend WithEvents lblTopUpInfoTitle As Label
    Friend WithEvents lblTopUpInfoBody As Label
    Friend WithEvents cardPlanner As RoundPanel
    Friend WithEvents lblPlannerTitle As Label
    Friend WithEvents lblPlannerSub As Label
    Friend WithEvents lblNameCaption As Label
    Friend WithEvents pnlNameField As RoundPanel
    Friend WithEvents txtApplianceName As TextBox
    Friend WithEvents lblWattsCaption As Label
    Friend WithEvents pnlWattsField As RoundPanel
    Friend WithEvents txtWattage As TextBox
    Friend WithEvents lblHoursCaption As Label
    Friend WithEvents pnlHoursField As RoundPanel
    Friend WithEvents txtHours As TextBox
    Friend WithEvents btnCalculateAppliance As Button
    Friend WithEvents btnClearAppliance As Button
    Friend WithEvents cardResult As RoundPanel
    Friend WithEvents lblResultTitle As Label
    Friend WithEvents lblApplianceResult As Label
    Friend WithEvents lblPlannerHint As Label
    Friend WithEvents btnApplOpen As Button
    Friend WithEvents cardHowCalc As RoundPanel
    Friend WithEvents lblHowCalcTitle As Label
    Friend WithEvents lblHowCalcBody As Label
    Friend WithEvents cardApplReports As RoundPanel
    Friend WithEvents lblApplReportsTitle As Label
    Friend WithEvents lblApplReportsSub As Label
    Friend WithEvents btnApplPdf As Button
    Friend WithEvents btnApplCsv As Button
    Friend WithEvents btnApplClear As Button
    Friend WithEvents dgvAppliances As DataGridView
    Friend WithEvents lblApplTotals As Label
    Friend WithEvents cardUsageReports As RoundPanel
    Friend WithEvents lblUsageReportsTitle As Label
    Friend WithEvents lblUsageReportsSub As Label
    Friend WithEvents btnExportPdf As Button
    Friend WithEvents btnExportCsv As Button
    Friend WithEvents btnRefreshReports As Button
    Friend WithEvents dgvUsageHistory As DataGridView
    Friend WithEvents lblUsageTotals As Label
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colUnits As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
    Friend WithEvents colApplDate As DataGridViewTextBoxColumn
    Friend WithEvents colApplName As DataGridViewTextBoxColumn
    Friend WithEvents colApplPower As DataGridViewTextBoxColumn
    Friend WithEvents colApplHours As DataGridViewTextBoxColumn
    Friend WithEvents colApplDaily As DataGridViewTextBoxColumn
    Friend WithEvents colApplMonthly As DataGridViewTextBoxColumn

End Class
