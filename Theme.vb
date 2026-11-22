Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

''' <summary>Shared colours / styling for PowerWise.</summary>
Public Module Theme
    Public ReadOnly Accent As Color = Color.FromArgb(&HB8, &H50, &H42)
    Public ReadOnly Dark As Color = Color.FromArgb(&H3A, &H2A, &H26)
    Public ReadOnly Soft As Color = Color.FromArgb(&HFB, &HF1, &HEC)
    Public ReadOnly Page As Color = Color.FromArgb(&HF7, &HEF, &HE9)
    Public ReadOnly Amber As Color = Color.FromArgb(&HE8, &H9A, &H3C)
    Public ReadOnly AmberText As Color = Color.FromArgb(&HD0, &H80, &H1A)
    Public ReadOnly Teal As Color = Color.FromArgb(&H2A, &H9D, &H8F)
    Public ReadOnly DeepTeal As Color = Color.FromArgb(&H26, &H46, &H53)
    Public ReadOnly Green As Color = Color.FromArgb(&H5B, &H8C, &H3A)
    Public ReadOnly Muted As Color = Color.FromArgb(&H8A, &H73, &H6C)
    Public ReadOnly Border As Color = Color.FromArgb(&HE6, &HCD, &HC3)

    Public Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
        Dim d As Integer = Math.Max(2, Math.Min(radius * 2, Math.Min(r.Width, r.Height)))
        Dim p As New GraphicsPath()
        p.AddArc(r.X, r.Y, d, d, 180, 90)
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        p.CloseFigure()
        Return p
    End Function

    ''' <summary>Gives a control rounded corners (and keeps them when it is resized).</summary>
    Public Sub Round(c As Control, radius As Integer)
        ApplyRegion(c, radius)
        AddHandler c.Resize, Sub(s As Object, e As EventArgs) ApplyRegion(c, radius)
    End Sub

    Private Sub ApplyRegion(c As Control, radius As Integer)
        If c.Width < 4 OrElse c.Height < 4 Then Return
        Using p = RoundedRect(New Rectangle(0, 0, c.Width, c.Height), radius)
            c.Region = New Region(p)
        End Using
    End Sub

    Public Sub StyleButton(b As Button, primary As Boolean)
        b.UseVisualStyleBackColor = False
        b.FlatStyle = FlatStyle.Flat
        b.Cursor = Cursors.Hand
        If primary Then
            b.BackColor = Accent
            b.ForeColor = Color.White
            b.FlatAppearance.BorderSize = 0
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(&H9C, &H3F, &H33)
            b.FlatAppearance.MouseDownBackColor = Dark
        Else
            b.BackColor = Color.White
            b.ForeColor = Accent
            b.FlatAppearance.BorderColor = Accent
            b.FlatAppearance.MouseOverBackColor = Soft
            b.FlatAppearance.MouseDownBackColor = Soft
        End If
    End Sub

    Public Sub StyleGrid(g As DataGridView)
        g.ReadOnly = True
        g.AllowUserToAddRows = False
        g.AllowUserToDeleteRows = False
        g.RowHeadersVisible = False
        g.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        g.BackgroundColor = Color.White
        g.BorderStyle = BorderStyle.None
        g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        g.GridColor = Color.FromArgb(&HF0, &HE1, &HDA)
        g.EnableHeadersVisualStyles = False
        g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        g.ColumnHeadersDefaultCellStyle.BackColor = Accent
        g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Accent
        g.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        g.ColumnHeadersHeight = 40
        g.RowTemplate.Height = 36
        g.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        g.DefaultCellStyle.ForeColor = Dark
        g.AlternatingRowsDefaultCellStyle.BackColor = Soft
        g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(&HF3, &HD3, &HC9)
        g.DefaultCellStyle.SelectionForeColor = Dark
    End Sub
End Module

''' <summary>A rounded card with optional shadow, accent stripe, border or gradient fill.</summary>
Public Class RoundPanel
    Inherits Panel

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property Radius As Integer = 18
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property FillColor As Color = Color.White
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property StripeColor As Color = Color.Empty
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property BorderColor As Color = Color.Empty
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property GradFrom As Color = Color.Empty
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property GradTo As Color = Color.Empty
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property Shadow As Boolean = True

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or
                 ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        If Width < 12 OrElse Height < 12 Then Return
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim off As Integer = If(Shadow, 5, 1)
        Dim rc As New Rectangle(0, 0, Width - off, Height - off)

        If Shadow Then
            Using sp = Theme.RoundedRect(New Rectangle(2, 4, rc.Width, rc.Height), Radius)
                Using sb As New SolidBrush(Color.FromArgb(34, 90, 50, 40))
                    g.FillPath(sb, sp)
                End Using
            End Using
        End If

        Using path = Theme.RoundedRect(rc, Radius)
            If (Not GradFrom.IsEmpty) AndAlso (Not GradTo.IsEmpty) Then
                Using lg As New LinearGradientBrush(rc, GradFrom, GradTo, 25.0F)
                    g.FillPath(lg, path)
                End Using
            Else
                Using sb As New SolidBrush(FillColor)
                    g.FillPath(sb, path)
                End Using
            End If
            If Not StripeColor.IsEmpty Then
                g.SetClip(path)
                Using sb As New SolidBrush(StripeColor)
                    g.FillRectangle(sb, 0, 0, 7, Height)
                End Using
                g.ResetClip()
            End If
            If Not BorderColor.IsEmpty Then
                Using pn As New Pen(BorderColor, 1.5F)
                    g.DrawPath(pn, path)
                End Using
            End If
        End Using
    End Sub
End Class
