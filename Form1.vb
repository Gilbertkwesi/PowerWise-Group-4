Imports System.IO

Imports System.Globalization

Imports System.Drawing.Printing

Imports System.Drawing.Drawing2D

Imports System.Text

Public Class Form1

    'Values used by the application

    Private balance As Double = 0

    Private totalUsed As Double = 0

    Private dailyUsage As Double = 0

    Private latestTopUp As Double = 0



    Private ReadOnly _user As String = ""

    ''' <summary>True when the user clicked "Log out" (Program then shows the login screen again).</summary>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property LoggedOut As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(username As String)
        InitializeComponent()
        _user = username
    End Sub

    ' ===============================================================
    '  LOOK & FEEL  -  the layout itself now lives in Form1.Designer.vb
    '  (open Form1.vb [Design] to see and edit it). Only the small
    '  run-time touches below are done in code.
    ' ===============================================================
    Private ReadOnly views As New Dictionary(Of String, Panel)
    Private ReadOnly navMap As New Dictionary(Of String, Button)

    Private Sub SetupUi()
        Text = If(_user = "", "PowerWise", $"PowerWise – {_user}")
        DoubleBuffered = True

        ' who is logged in
        lblWho.Text = If(_user = "", "", "👤  " & _user)
        lblWho.Left = pnlHeader.Width - lblWho.Width - 28
        lblWelcome.Text = If(_user = "", "Welcome to PowerWise 👋", $"Welcome back, {_user} 👋")

        ' energy tip of the day
        Dim tips As String() = {
            "Switch appliances off at the socket – standby power quietly eats your units.",
            "LED bulbs use up to 80% less energy than old bulbs and last much longer.",
            "Iron in one batch instead of a little every day.",
            "Keep the fridge door shut and its seals clean – it works less and saves units.",
            "Unplug chargers when you are not using them.",
            "Run heavy appliances only when you are sure you have enough units left."}
        lblTip.Text = tips(DateTime.Now.DayOfYear Mod tips.Length)

        ' menu pages and the sidebar buttons that open them
        views("Dashboard") = pnlDashboard
        views("Reading") = pnlReading
        views("TopUp") = pnlTopUp
        views("Planner") = pnlPlanner
        views("PlannerReports") = pnlPlannerReports
        views("Reports") = pnlReports
        navMap("Dashboard") = btnDashboard
        navMap("Reading") = btnReading
        navMap("TopUp") = btnTopup
        navMap("Planner") = btnAppliances
        navMap("PlannerReports") = btnApplReports
        navMap("Reports") = btnReports

        ' rounded corners (can't be previewed in the designer)
        For Each b As Button In New Button() {btnDashboard, btnReading, btnTopup, btnAppliances, btnApplReports,
                                              btnReports, btnLogout, btnCalculate, btnClearReading, btnRecordTopUp,
                                              btnCalculateAppliance, btnClearAppliance, btnApplOpen, btnApplPdf,
                                              btnApplCsv, btnApplClear, btnExportPdf, btnExportCsv, btnRefreshReports}
            Theme.Round(b, 14)
        Next

        ' text boxes: highlight their card border while typing
        For Each tb As TextBox In New TextBox() {txtPrevious, txtCurrent, txtDaily, txtTopUpUnits, txtAmountPaid,
                                                 txtApplianceName, txtWattage, txtHours}
            HookField(tb)
        Next

        ShowView("Dashboard")
    End Sub

    Private Sub HookField(tb As TextBox)
        Dim fld As RoundPanel = TryCast(tb.Parent, RoundPanel)
        If fld Is Nothing Then Return
        AddHandler tb.Enter, Sub(s As Object, e As EventArgs)
                                 fld.BorderColor = Theme.Accent
                                 fld.Invalidate()
                             End Sub
        AddHandler tb.Leave, Sub(s As Object, e As EventArgs)
                                 fld.BorderColor = Theme.Border
                                 fld.Invalidate()
                             End Sub
    End Sub

    Private Sub PaintHeader(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint
        Dim p As Panel = DirectCast(sender, Panel)
        If p.Width < 2 OrElse p.Height < 2 Then Return
        Using lg As New LinearGradientBrush(p.ClientRectangle, Theme.Accent, Theme.Amber, LinearGradientMode.Horizontal)
            e.Graphics.FillRectangle(lg, p.ClientRectangle)
        End Using
    End Sub

    Private Sub PaintSidebar(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        Dim p As Panel = DirectCast(sender, Panel)
        If p.Width < 2 OrElse p.Height < 2 Then Return
        Using lg As New LinearGradientBrush(p.ClientRectangle, Theme.Dark, Color.FromArgb(&H24, &H18, &H15), LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(lg, p.ClientRectangle)
        End Using
    End Sub

    ' ---------- clear buttons ----------
    Private Sub OnClearReading(sender As Object, e As EventArgs) Handles btnClearReading.Click
        ClearReadingInputs()
        txtPrevious.Focus()
    End Sub

    Private Sub OnClearAppliance(sender As Object, e As EventArgs) Handles btnClearAppliance.Click
        txtApplianceName.Clear()
        txtWattage.Clear()
        txtHours.Clear()
        lblApplianceResult.Text = "Your appliance's daily and monthly consumption will appear here."
        lblPlannerHint.Text = ""
        txtApplianceName.Focus()
    End Sub

    ' ---------- navigation ----------
    Private Sub ShowView(key As String)
        For Each kv As KeyValuePair(Of String, Panel) In views
            kv.Value.Visible = (kv.Key = key)
        Next
        If views.ContainsKey(key) Then views(key).BringToFront()
        For Each kv As KeyValuePair(Of String, Button) In navMap
            kv.Value.BackColor = If(kv.Key = key, Theme.Accent, Theme.Dark)
        Next
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        UpdateDashboard()
        ShowView("Dashboard")
    End Sub

    Private Sub btnReading_Click(sender As Object, e As EventArgs) Handles btnReading.Click
        ShowView("Reading")
        txtPrevious.Focus()
    End Sub

    Private Sub btnTopup_Click(sender As Object, e As EventArgs) Handles btnTopup.Click
        ShowView("TopUp")
        txtTopUpUnits.Focus()
    End Sub

    Private Sub btnAppliances_Click(sender As Object, e As EventArgs) Handles btnAppliances.Click
        ShowView("Planner")
        txtApplianceName.Focus()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ShowView("Reports")
    End Sub

    Private Sub btnApplReports_Click(sender As Object, e As EventArgs) Handles btnApplReports.Click, btnApplOpen.Click
        ShowView("PlannerReports")
    End Sub

    Private Sub OnLogout(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoggedOut = True
        Close()
    End Sub

    ' ---------- dashboard text ----------
    Private Sub UpdateAlert()
        If balance <= 0 AndAlso dailyUsage <= 0 Then
            lblAlert.Text = "Add a meter reading or a top-up to get started."
            lblAlert.ForeColor = Color.White
        ElseIf dailyUsage > 0 AndAlso balance / dailyUsage < 3 Then
            lblAlert.Text = "⚠ Low balance – less than 3 days of units left. Consider topping up soon."
            lblAlert.ForeColor = Color.FromArgb(255, 255, 224, 160)
        Else
            lblAlert.Text = "✔ Your balance looks healthy. Here's your energy at a glance."
            lblAlert.ForeColor = Color.White
        End If
    End Sub

    Private Sub UpdateRecent()
        Dim n As Integer = dgvUsageHistory.Rows.Count
        If n = 0 Then
            lblRecent.Text = "Nothing yet – record a meter reading or a top-up and it will show up here."
            Return
        End If
        Dim lines As New List(Of String)
        For i As Integer = n - 1 To Math.Max(0, n - 5) Step -1
            Dim r As DataGridViewRow = dgvUsageHistory.Rows(i)
            Dim kind As String = CellText(r, 1)
            If kind = "Top-Up" Then
                lines.Add($"💳  Top-Up  ·  +{CellText(r, 2)} kWh for GH₵ {CellText(r, 3)}  ·  {CellText(r, 0)}")
            Else
                lines.Add($"📟  Meter Reading  ·  {CellText(r, 2)} kWh used  ·  {CellText(r, 0)}")
            End If
        Next
        lblRecent.Text = String.Join(vbCrLf & vbCrLf, lines)
    End Sub

    Private Sub SumUsage(ByRef used As Double, ByRef paid As Double)
        used = 0
        paid = 0
        For Each r As DataGridViewRow In dgvUsageHistory.Rows
            If CellText(r, 1) = "Meter Reading" Then used += ParseNumber(CellText(r, 2))
            If CellText(r, 1) = "Top-Up" Then paid += ParseNumber(CellText(r, 3))
        Next
    End Sub

    Private Sub UpdateUsageTotals()
        Dim used As Double, paid As Double
        SumUsage(used, paid)
        lblUsageTotals.Text = $"🧾 {dgvUsageHistory.Rows.Count} transactions   ·   ⚡ {used:N2} kWh used   ·   💰 GH₵ {paid:N2} spent on top-ups"
    End Sub

    Private Sub SumAppliances(ByRef n As Integer, ByRef daily As Double, ByRef monthly As Double)
        n = dgvAppliances.Rows.Count
        daily = 0
        monthly = 0
        For Each r As DataGridViewRow In dgvAppliances.Rows
            daily += ParseNumber(CellText(r, 4))
            monthly += ParseNumber(CellText(r, 5))
        Next
    End Sub

    Private Sub UpdateApplTotals()
        Dim n As Integer, d As Double, m As Double
        SumAppliances(n, d, m)
        lblApplTotals.Text = $"🔌 {n} appliances   ·   ⚡ {d:N2} kWh per day   ·   📅 {m:N2} kWh per month"
    End Sub

    Private Sub AddApplianceRecord(name As String, watts As Double, hours As Double, daily As Double, monthly As Double)
        dgvAppliances.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), name, watts.ToString("0.##"),
                               hours.ToString("0.##"), daily.ToString("0.00"), monthly.ToString("0.00"))
        lblPlannerHint.Text = "✔ Saved to Appliance Planner Reports"
        Persist()
        UpdateApplTotals()
    End Sub

    ' ---------- export (PDF + CSV) ----------
    Private Function CellText(r As DataGridViewRow, index As Integer) As String
        Return Convert.ToString(r.Cells(index).Value)
    End Function

    Private Function ParseNumber(txt As String) As Double
        Dim v As Double
        If Double.TryParse(txt, NumberStyles.Float, CultureInfo.CurrentCulture, v) Then Return v
        Return 0.0
    End Function

    Private Function Fit(txt As String, width As Integer) As String
        If txt.Length >= width Then Return txt.Substring(0, width - 1) & " "
        Return txt.PadRight(width)
    End Function

    Private Sub ExportGridCsv(grid As DataGridView, fileBase As String)
        If grid.Rows.Count = 0 Then
            MessageBox.Show("There is nothing to export yet.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Using sfd As New SaveFileDialog With {
            .Filter = "CSV file (*.csv)|*.csv",
            .FileName = $"{fileBase}_{DateTime.Now:yyyyMMdd}.csv"}
            If sfd.ShowDialog() <> DialogResult.OK Then Return
            Try
                Dim sb As New StringBuilder()
                Dim heads As New List(Of String)
                For Each c As DataGridViewColumn In grid.Columns
                    heads.Add(CsvValue(c.HeaderText))
                Next
                sb.AppendLine(String.Join(",", heads))
                For Each r As DataGridViewRow In grid.Rows
                    Dim cells As New List(Of String)
                    For i As Integer = 0 To grid.Columns.Count - 1
                        cells.Add(CsvValue(CellText(r, i)))
                    Next
                    sb.AppendLine(String.Join(",", cells))
                Next
                File.WriteAllText(sfd.FileName, sb.ToString(), New UTF8Encoding(True))
                MessageBox.Show("File saved.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Could not save the file: " & ex.Message, "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ExportGridPdf(grid As DataGridView, widths As Integer(), header As List(Of String),
                              summary As String, fileBase As String)
        If grid.Rows.Count = 0 Then
            MessageBox.Show("There is nothing to export yet.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim lines As New List(Of String)(header)
        lines.Add("")
        Dim head As String = ""
        For i As Integer = 0 To grid.Columns.Count - 1
            head &= Fit(grid.Columns(i).HeaderText.Replace("GH₵", "GHS"), widths(i))
        Next
        lines.Add(head)
        lines.Add(New String("-"c, widths.Sum()))
        For Each r As DataGridViewRow In grid.Rows
            Dim ln As String = ""
            For i As Integer = 0 To grid.Columns.Count - 1
                ln &= Fit(CellText(r, i), widths(i))
            Next
            lines.Add(ln)
        Next
        lines.Add("")
        lines.Add(summary)

        Using sfd As New SaveFileDialog With {
            .Filter = "PDF file (*.pdf)|*.pdf",
            .FileName = $"{fileBase}_{DateTime.Now:yyyyMMdd}.pdf"}
            If sfd.ShowDialog() <> DialogResult.OK Then Return
            Try
                Dim index As Integer = 0
                Using pd As New PrintDocument()
                    pd.PrinterSettings.PrinterName = "Microsoft Print to PDF"
                    If Not pd.PrinterSettings.IsValid Then
                        MessageBox.Show("'Microsoft Print to PDF' is not available on this computer. Use Export CSV instead.",
                                        "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    pd.PrinterSettings.PrintToFile = True
                    pd.PrinterSettings.PrintFileName = sfd.FileName
                    AddHandler pd.PrintPage, Sub(s As Object, pe As PrintPageEventArgs)
                                                 Using f As New Font("Consolas", 9.5F)
                                                     Dim lh As Single = f.GetHeight(pe.Graphics) + 3
                                                     Dim y As Single = pe.MarginBounds.Top
                                                     While index < lines.Count AndAlso y + lh <= pe.MarginBounds.Bottom
                                                         pe.Graphics.DrawString(lines(index), f, Brushes.Black, pe.MarginBounds.Left, y)
                                                         y += lh
                                                         index += 1
                                                     End While
                                                 End Using
                                                 pe.HasMorePages = index < lines.Count
                                             End Sub
                    pd.Print()
                End Using
                MessageBox.Show("PDF saved.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Could not create the PDF: " & ex.Message, "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub OnExportCsv(sender As Object, e As EventArgs) Handles btnExportCsv.Click
        ExportGridCsv(dgvUsageHistory, "PowerWise_Usage_Report")
    End Sub

    Private Sub OnExportPdf(sender As Object, e As EventArgs) Handles btnExportPdf.Click
        Dim used As Double, paid As Double
        SumUsage(used, paid)
        Dim hdr As New List(Of String) From {
            "PowerWise - Usage Report",
            $"User: {If(_user = "", "-", _user)}    Generated: {DateTime.Now:yyyy-MM-dd HH:mm}",
            $"Units left now: {balance:N2} kWh    Daily usage: {dailyUsage:N2} kWh"}
        ExportGridPdf(dgvUsageHistory, New Integer() {18, 15, 14, 16, 16}, hdr,
                      $"Totals - units used: {used:N2} kWh   |   spent on top-ups: GHS {paid:N2}",
                      "PowerWise_Usage_Report")
    End Sub

    Private Sub OnApplCsv(sender As Object, e As EventArgs) Handles btnApplCsv.Click
        ExportGridCsv(dgvAppliances, "PowerWise_Appliance_Planner_Report")
    End Sub

    Private Sub OnApplPdf(sender As Object, e As EventArgs) Handles btnApplPdf.Click
        Dim n As Integer, d As Double, m As Double
        SumAppliances(n, d, m)
        Dim hdr As New List(Of String) From {
            "PowerWise - Appliance Planner Report",
            $"User: {If(_user = "", "-", _user)}    Generated: {DateTime.Now:yyyy-MM-dd HH:mm}"}
        ExportGridPdf(dgvAppliances, New Integer() {17, 18, 10, 11, 13, 14}, hdr,
                      $"Totals - appliances: {n}   |   {d:N2} kWh per day   |   {m:N2} kWh per month",
                      "PowerWise_Appliance_Planner_Report")
    End Sub

    Private Sub OnApplClear(sender As Object, e As EventArgs) Handles btnApplClear.Click
        If dgvAppliances.Rows.Count = 0 Then Return
        If MessageBox.Show("Remove all saved appliance calculations?", "PowerWise",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        dgvAppliances.Rows.Clear()
        Persist()
        UpdateApplTotals()
    End Sub

    ' ---------- saved data (per user, in %AppData%\PowerWise_Group4) ----------
    Private Function GridToRows(grid As DataGridView) As List(Of HistoryRow)
        Dim result As New List(Of HistoryRow)
        For Each r As DataGridViewRow In grid.Rows
            Dim hr As New HistoryRow()
            For Each c As DataGridViewCell In r.Cells
                hr.Cells.Add(Convert.ToString(c.Value))
            Next
            result.Add(hr)
        Next
        Return result
    End Function

    Private Sub Persist()
        If _user = "" Then Return
        Dim st As New SavedState With {
            .Balance = balance, .TotalUsed = totalUsed,
            .DailyUsage = dailyUsage, .LatestTopUp = latestTopUp}
        st.Rows = GridToRows(dgvUsageHistory)
        st.Appliances = GridToRows(dgvAppliances)
        DataStore.SaveState(_user, st)
    End Sub

    Private Sub LoadPersisted()
        If _user = "" Then Return
        Dim st As SavedState = DataStore.LoadState(_user)
        balance = st.Balance
        totalUsed = st.TotalUsed
        dailyUsage = st.DailyUsage
        latestTopUp = st.LatestTopUp
        For Each h As HistoryRow In st.Rows
            If h.Cells.Count = dgvUsageHistory.Columns.Count Then
                dgvUsageHistory.Rows.Add(h.Cells.Cast(Of Object)().ToArray())
            End If
        Next
        For Each h As HistoryRow In st.Appliances
            If h.Cells.Count = dgvAppliances.Columns.Count Then
                dgvAppliances.Rows.Add(h.Cells.Cast(Of Object)().ToArray())
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupUi()
        LoadPersisted()
        UpdateDashboard()
    End Sub

    Private Sub UpdateDashboard()

        UpdateAlert()
        UpdateRecent()
        UpdateUsageTotals()
        UpdateApplTotals()

        lblBalance.Text = balance.ToString("0.00") & " kWh"

        lblDailyUsage.Text = dailyUsage.ToString("0.00") & " kWh"

        lblDaysLeft.Text = "0 days"

        If dailyUsage > 0 Then
            lblDaysLeft.Text = (balance / dailyUsage).ToString("0.0") & " days"

        End If

        If latestTopUp > 0 Then
            lblLatestTopUp.Text = "GH₵ " & latestTopUp.ToString("0.00")

        Else

            lblLatestTopUp.Text = "None"

        End If

    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If txtPrevious.Text.Trim() = "" OrElse txtCurrent.Text.Trim() = "" OrElse txtDaily.Text.Trim() = "" Then

            MessageBox.Show("Enter values in all three fields.")

            Exit Sub

        End If

        If Not IsNumeric(txtPrevious.Text) OrElse Not IsNumeric(txtCurrent.Text) OrElse Not IsNumeric(txtDaily.Text) Then

            MessageBox.Show("Enter numbers only.")

            Exit Sub

        End If

        Dim previous As Double = CDbl(txtPrevious.Text)

        Dim current As Double = CDbl(txtCurrent.Text)

        Dim daily As Double = CDbl(txtDaily.Text)

        If previous < 0 OrElse current < 0 OrElse daily <= 0 Then

            MessageBox.Show("Units cannot be negative. Daily usage must be positive.")

            Exit Sub

        End If

        If current > previous Then

            MessageBox.Show("Current units cannot exceed previous units.")

            Exit Sub

        End If

        Dim used As Double = previous - current

        totalUsed += used

        balance = current

        dailyUsage = daily

        dgvUsageHistory.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "Meter Reading", used.ToString("0.00"), "-", balance.ToString("0.00"))

        Persist()

        UpdateDashboard()

        MessageBox.Show("Units used: " & used.ToString("0.00") & " kWh" & vbCrLf & "Estimated days remaining: " & (balance / dailyUsage).ToString("0.0"))

    End Sub

    Private Sub btnRecordTopUp_Click(sender As Object, e As EventArgs) Handles btnRecordTopUp.Click

        If txtTopUpUnits.Text.Trim() = "" OrElse txtAmountPaid.Text.Trim() = "" Then

            MessageBox.Show("Enter units and amount paid.")

            Exit Sub

        End If

        If Not IsNumeric(txtTopUpUnits.Text) OrElse Not IsNumeric(txtAmountPaid.Text) Then

            MessageBox.Show("Enter numbers only.")

            Exit Sub

        End If

        Dim units As Double = CDbl(txtTopUpUnits.Text)

        Dim amount As Double = CDbl(txtAmountPaid.Text)

        If units <= 0 OrElse amount <= 0 Then

            MessageBox.Show("Units and amount must be greater than zero.")

            Exit Sub

        End If

        balance += units

        latestTopUp = amount

        dgvUsageHistory.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "Top-Up", units.ToString("0.00"), amount.ToString("0.00"), balance.ToString("0.00"))

        Persist()

        UpdateDashboard()

        txtTopUpUnits.Clear()

        txtAmountPaid.Clear()

        MessageBox.Show("Top-up recorded successfully." & vbCrLf & "New balance: " & balance.ToString("0.00") & " kWh")

    End Sub


    Private Sub btnCalculateAppliance_Click(sender As Object, e As EventArgs) Handles btnCalculateAppliance.Click

        Dim applianceName As String = txtApplianceName.Text.Trim()

        If applianceName = "" Then

            MessageBox.Show("Please enter the appliance name.")

            txtApplianceName.Focus()

            Exit Sub

        End If

        If txtWattage.Text.Trim() = "" OrElse Not IsNumeric(txtWattage.Text) Then

            MessageBox.Show("Enter a valid power rating in watts.")

            txtWattage.Focus()

            Exit Sub

        End If

        If txtHours.Text.Trim() = "" OrElse Not IsNumeric(txtHours.Text) Then

            MessageBox.Show("Enter valid hours used per day.")

            txtHours.Focus()

            Exit Sub

        End If

        Dim powerRating As Double = CDbl(txtWattage.Text)

        Dim hoursPerDay As Double = CDbl(txtHours.Text)

        If powerRating <= 0 Then

            MessageBox.Show("Power rating must be greater than zero.")

            txtWattage.Focus()

            Exit Sub

        End If

        If hoursPerDay <= 0 OrElse hoursPerDay > 24 Then

            MessageBox.Show("Hours must be greater than zero and at most 24.")

            txtHours.Focus()

            Exit Sub

        End If

        Dim dailyUnits As Double = (powerRating * hoursPerDay) / 1000

        Dim monthlyUnits As Double = dailyUnits * 30

        lblApplianceResult.Text = "Appliance: " & applianceName & vbCrLf & "Daily consumption: " & dailyUnits.ToString("0.00") & " kWh" & vbCrLf & "Monthly consumption: " & monthlyUnits.ToString("0.00") & " kWh"

        AddApplianceRecord(applianceName, powerRating, hoursPerDay, dailyUnits, monthlyUnits)

    End Sub

    Private Sub btnRefreshReports_Click(sender As Object, e As EventArgs) Handles btnRefreshReports.Click

        dgvUsageHistory.EndEdit()

        dgvUsageHistory.Refresh()

        UpdateDashboard()

        If dgvUsageHistory.Rows.Count = 0 Then

            MessageBox.Show("No usage records available. Please calculate units or record a top-up first.")

            Exit Sub

        End If

        MessageBox.Show("Usage report refreshed successfully." & vbCrLf & "Total transactions: " & dgvUsageHistory.Rows.Count.ToString() & vbCrLf & "Current balance: " & balance.ToString("0.00") & " kWh")

    End Sub



    Private Function CsvValue(value As String) As String

        Return """" & value.Replace("""", """""") & """"

    End Function



    Private Sub ClearReadingInputs()

        txtPrevious.Clear()

        txtCurrent.Clear()

        txtDaily.Clear()

    End Sub


    Private Sub ClearAllInputs()

        ClearReadingInputs()

        txtTopUpUnits.Clear()

        txtAmountPaid.Clear()

        txtApplianceName.Clear()

        txtWattage.Clear()

        txtHours.Clear()

        lblApplianceResult.Text = ""

    End Sub

End Class