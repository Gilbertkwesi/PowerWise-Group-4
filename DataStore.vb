Imports System.IO
Imports System.Security.Cryptography
Imports System.Text.Json

Public Class UserAccount
    Public Property Username As String = ""
    Public Property Salt As String = ""
    Public Property PinHash As String = ""
End Class

''' <summary>One row of the usage history table.</summary>
Public Class HistoryRow
    Public Property Cells As New List(Of String)
End Class

''' <summary>Everything Group 4 remembers for one user.</summary>
Public Class SavedState
    Public Property Balance As Double
    Public Property TotalUsed As Double
    Public Property DailyUsage As Double
    Public Property LatestTopUp As Double
    Public Property Rows As New List(Of HistoryRow)
    Public Property Appliances As New List(Of HistoryRow)
End Class

''' <summary>Stores user accounts (PIN hashed with PBKDF2) as JSON in %AppData%\PowerWise_Group4.</summary>
Public Module DataStore

    Private ReadOnly Folder As String =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PowerWise_Group4")
    Private ReadOnly UsersFile As String = Path.Combine(Folder, "users.json")
    Private ReadOnly JsonOpts As New JsonSerializerOptions With {.WriteIndented = True}

    Private Function LoadUsers() As List(Of UserAccount)
        Try
            If File.Exists(UsersFile) Then
                Dim list = JsonSerializer.Deserialize(Of List(Of UserAccount))(File.ReadAllText(UsersFile))
                If list IsNot Nothing Then Return list
            End If
        Catch
            ' corrupt file -> start fresh list
        End Try
        Return New List(Of UserAccount)
    End Function

    Private Sub SaveUsers(users As List(Of UserAccount))
        Directory.CreateDirectory(Folder)
        File.WriteAllText(UsersFile, JsonSerializer.Serialize(users, JsonOpts))
    End Sub

    Private Function Hash(pin As String, salt As Byte()) As String
        Return Convert.ToBase64String(Rfc2898DeriveBytes.Pbkdf2(pin, salt, 100000, HashAlgorithmName.SHA256, 32))
    End Function

    Public Function AnyUsers() As Boolean
        Return LoadUsers().Count > 0
    End Function

    ''' <summary>Creates a new account. Returns False if the username is already taken.</summary>
    Public Function Register(username As String, pin As String) As Boolean
        Dim users = LoadUsers()
        If users.Any(Function(u) String.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase)) Then Return False
        Dim salt = RandomNumberGenerator.GetBytes(16)
        users.Add(New UserAccount With {
            .Username = username,
            .Salt = Convert.ToBase64String(salt),
            .PinHash = Hash(pin, salt)})
        SaveUsers(users)
        Return True
    End Function

    Public Function Authenticate(username As String, pin As String) As Boolean
        Dim acct = LoadUsers().FirstOrDefault(Function(u) String.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase))
        If acct Is Nothing Then Return False
        Dim salt = Convert.FromBase64String(acct.Salt)
        Return String.Equals(acct.PinHash, Hash(pin, salt), StringComparison.Ordinal)
    End Function

    Private Function StatePath(username As String) As String
        Dim safe As String = String.Concat(username.ToLowerInvariant().Select(Function(c) If(Char.IsLetterOrDigit(c), c, "_"c)))
        Return Path.Combine(Folder, $"data_{safe}.json")
    End Function

    Public Function LoadState(username As String) As SavedState
        Try
            Dim p = StatePath(username)
            If File.Exists(p) Then
                Dim st = JsonSerializer.Deserialize(Of SavedState)(File.ReadAllText(p))
                If st IsNot Nothing Then Return st
            End If
        Catch
        End Try
        Return New SavedState()
    End Function

    Public Sub SaveState(username As String, state As SavedState)
        Directory.CreateDirectory(Folder)
        File.WriteAllText(StatePath(username), JsonSerializer.Serialize(state, JsonOpts))
    End Sub

End Module
