Imports System.Data.OleDb
Imports System.IO

Public Class backup

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub btn_browser_Click(sender As Object, e As EventArgs) Handles btn_browser.Click
        Dim folderdialog As New FolderBrowserDialog
        folderdialog.ShowDialog()
        txt_filename.Text = folderdialog.SelectedPath
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click

        'Call diskonek()
        conn.Close()


        Try
            Dim sDBFile As String = "" & System.Environment.CurrentDirectory & "\database.mdb"
            Dim sBackUpFile As String = txt_filename.Text
            If Not System.IO.Directory.Exists(sBackUpFile) Then
                System.IO.Directory.CreateDirectory(sBackUpFile)
            End If
            sBackUpFile &= "\database.mdb"

            If File.Exists(sDBFile) Then
                Dim db As New DAO.DBEngine

                db.CompactDatabase(sDBFile, sBackUpFile)
            End If

            If File.Exists(sBackUpFile) Then
                File.Copy(sBackUpFile, sDBFile, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Database berhasil di backup", MsgBoxStyle.Information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim sDBFile As String = txt_filename.Text
            Dim sBackUpFile As String = "" & System.Environment.CurrentDirectory & "\database.mdb"
            If Not System.IO.Directory.Exists(sDBFile) Then
                System.IO.Directory.CreateDirectory(sDBFile)
            End If
            sDBFile &= "\database.mdb"

            If File.Exists(sDBFile) Then
                Dim db As New DAO.DBEngine

                db.CompactDatabase(sDBFile, sBackUpFile)
            End If

            If File.Exists(sBackUpFile) Then
                File.Copy(sBackUpFile, sDBFile, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Database berhasil di Restore", MsgBoxStyle.Information)
    End Sub

    Private Sub backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class