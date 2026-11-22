Imports System.Windows.Forms

Public Module Program

    <STAThread>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Do
            Using login As New LoginForm()
                If login.ShowDialog() <> DialogResult.OK Then Return
                Using main As New Form1(login.LoggedInUser)
                    Application.Run(main)
                    ' Loop back to the login screen only if the user clicked "Log out"
                    If Not main.LoggedOut Then Return
                End Using
            End Using
        Loop
    End Sub

End Module
