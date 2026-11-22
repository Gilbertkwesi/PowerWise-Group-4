Imports System.Drawing
Imports System.Windows.Forms
Public Class LoginForm
    Inherits Form

    Private ReadOnly txtUser As New TextBox()
    Private ReadOnly txtPin As New TextBox()
    Private ReadOnly btnLogin As New Button()
    Private ReadOnly btnRegister As New Button()
    Private ReadOnly lblInfo As New Label()

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property LoggedInUser As String = ""

    Public Sub New()
        Text = "PowerWise – Sign in"
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        StartPosition = FormStartPosition.CenterScreen
        ClientSize = New Size(380, 340)
        BackColor = Color.White
        Font = New Font("Segoe UI", 10)

        Dim banner As New Panel With {.Dock = DockStyle.Top, .Height = 90, .BackColor = Theme.Accent}
        banner.Controls.Add(New Label With {
            .Text = "⚡ PowerWise", .ForeColor = Color.White, .Font = New Font("Segoe UI", 20, FontStyle.Bold),
            .AutoSize = True, .Location = New Point(20, 12)})
        banner.Controls.Add(New Label With {
            .Text = "Know your units before they run out", .ForeColor = Color.White,
            .AutoSize = True, .Location = New Point(24, 55)})
        Controls.Add(banner)

        lblInfo.Location = New Point(24, 102)
        lblInfo.Size = New Size(335, 40)
        lblInfo.ForeColor = Color.DimGray
        lblInfo.Text = If(DataStore.AnyUsers(), "Enter your username and PIN.", "Welcome! Choose a username and a 4–6 digit PIN, then click Create account.")
        Controls.Add(lblInfo)

        Controls.Add(New Label With {.Text = "Username", .AutoSize = True, .Location = New Point(24, 150)})
        txtUser.Location = New Point(24, 172)
        txtUser.Width = 332
        Controls.Add(txtUser)

        Controls.Add(New Label With {.Text = "PIN (4–6 digits)", .AutoSize = True, .Location = New Point(24, 208)})
        txtPin.Location = New Point(24, 230)
        txtPin.Width = 332
        txtPin.UseSystemPasswordChar = True
        txtPin.MaxLength = 6
        Controls.Add(txtPin)

        btnLogin.Text = "Log in"
        btnLogin.Location = New Point(24, 280)
        btnLogin.Size = New Size(160, 36)
        Theme.StyleButton(btnLogin, True)
        Controls.Add(btnLogin)

        btnRegister.Text = "Create account"
        btnRegister.Location = New Point(196, 280)
        btnRegister.Size = New Size(160, 36)
        Theme.StyleButton(btnRegister, False)
        Controls.Add(btnRegister)

        AcceptButton = btnLogin
        AddHandler btnLogin.Click, AddressOf OnLogin
        AddHandler btnRegister.Click, AddressOf OnRegister
        AddHandler txtPin.KeyPress, Sub(s, e) e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar))
    End Sub

    Private Function InputsValid() As Boolean
        If txtUser.Text.Trim().Length < 2 Then
            MessageBox.Show("Please enter a username (at least 2 characters).", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If txtPin.Text.Length < 4 OrElse txtPin.Text.Length > 6 Then
            MessageBox.Show("The PIN must be 4 to 6 digits.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub OnLogin(sender As Object, e As EventArgs)
        If Not InputsValid() Then Return
        If DataStore.Authenticate(txtUser.Text.Trim(), txtPin.Text) Then
            LoggedInUser = txtUser.Text.Trim()
            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Wrong username or PIN.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPin.Clear()
            txtPin.Focus()
        End If
    End Sub

    Private Sub OnRegister(sender As Object, e As EventArgs)
        If Not InputsValid() Then Return
        If DataStore.Register(txtUser.Text.Trim(), txtPin.Text) Then
            MessageBox.Show("Account created! You can now log in.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnLogin.PerformClick()
        Else
            MessageBox.Show("That username is already taken.", "PowerWise", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
