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
        Try
            Dim sDBFile As String = "" & System.Environment.CurrentDirectory & "\database.mdb"
            Dim sBackUpFile As String = txt_filename.Text
            If Not System.IO.Directory.Exists(sBackUpFile) Then
                System.IO.Directory.CreateDirectory(sBackUpFile)
            End If
            sBackUpFile &= "\database.mdb"

            If File.Exists(sDBFile) Then
                Dim db As New dao.DBEngine

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
End Class