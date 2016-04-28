Imports System.Data.OleDb
Public Class maintain
    Dim con As New OleDbConnection
    Sub Open_Koneksi()
        con.ConnectionString = "Provider=microsoft.jet.oledb.4.0" & _
                               ";Data Source=database.mdb;" & _
                               "Persist Security Info=False;"
        con.Open()
    End Sub
    Private Sub maintain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        membermenu.Show()
        Me.Hide()
    End Sub

    Private Sub firmax3r_ValueChanged(sender As Object, e As EventArgs) Handles firmax3r.ValueChanged
        totalpcs.Text = firmax3r.Value + o2max3r.Value
        totalset.Text = totalpcs.Text / 2
        amountr.Text = totalset.Text * 1000000
    End Sub
    Private Sub o2max3r_ValueChanged(sender As Object, e As EventArgs) Handles o2max3r.ValueChanged
        totalpcs.Text = firmax3r.Value + o2max3r.Value
        totalset.Text = totalpcs.Text / 2
        amountr.Text = totalset.Text * 1000000
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        noform.Text = ""
        userid.Text = ""
        nama.Text = ""
        notelpon.Text = ""
        saldomaintainrm.Text = ""
        saldomaintainidr.Text = ""
        kurangbayar.Text = ""
        firmax3r.Value = 0
        o2max3r.Value = 0
        totalpcs.Text = ""
        totalset.Text = ""
        amountr.Text = ""
        ordered.Text = ""
        proceeded.Text = ""
        finalcheck.Text = ""
        datainput.Text = ""
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If noform.Text = "" Then
            MessageBox.Show("No Form tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            noform.Focus()
            Exit Sub
        ElseIf userid.Text = "" Then
            MessageBox.Show("User ID tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            userid.Focus()
            Exit Sub
        ElseIf nama.Text = "" Then
            MessageBox.Show("Nama tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            nama.Focus()
            Exit Sub
        ElseIf notelpon.Text = "" Then
            MessageBox.Show("No Telpon tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            notelpon.Focus()
            Exit Sub
        ElseIf firmax3r.Value = 0 Then
            MessageBox.Show("Pembelian FIRMAX3 minimal 1 ...", "Peringatan", MessageBoxButtons.OK)
            firmax3r.Focus()
            Exit Sub
        ElseIf o2max3r.Value = 0 Then
            MessageBox.Show("Pembelian O2 MAX3 minimal 1 ...", "Peringatan", MessageBoxButtons.OK)
            o2max3r.Focus()
            Exit Sub
        ElseIf ordered.Text = "" Then
            MessageBox.Show("Kolom Nama Ordered By tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            ordered.Focus()
            Exit Sub
        ElseIf proceeded.Text = "" Then
            MessageBox.Show("Kolom Nama Proceeded By tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            proceeded.Focus()
            Exit Sub
        Else
            Dim myCommand As New OleDbCommand
            Dim SQL As String
            Try
                If Not con.State = ConnectionState.Open Then Open_Koneksi()
                SQL = "INSERT INTO Form-Pembalian-Maintain (Tanggal, user_id, nama, No_Telp, Saldo_Maintain_RM, Saldo_Maintain_IDR, Kurang_Bayar, Prod_firmax3-R, Prod_O2max3-R, TotalpcsR, TotalsetR, AmountR, Note, Final_Check, Data_Input, Ordered_By, Proceed_By) VALUES " &
                          "('" & tanggal.Text & "', '" & userid.Text & "', '" & nama.Text & "', '" & notelpon.Text & "', '" & saldomaintainrm.Text & "', '" & saldomaintainidr.Text & "', '" & kurangbayar.Text & "', '" & firmax3r.Value & "', '" & o2max3r.Value & "', '" & totalpcs.Text & "', '" & totalset.Text & "', '" & amountr.Text & "', '" & note.Text & "', '" & finalcheck.Text & "', '" & datainput.Text & "', '" & ordered.Text & "', '" & proceeded.Text & "')"


                myCommand.Connection = con
                myCommand.CommandText = SQL
                myCommand.ExecuteNonQuery()

                MsgBox("Data baru tersimpan")

                noform.Text = String.Empty
                userid.Text = String.Empty
                nama.Text = String.Empty
                notelpon.Text = String.Empty
                firmax3r.Value = String.Empty
                o2max3r.Value = String.Empty
                totalpcs.Text = String.Empty
                totalset.Text = String.Empty
                amountr.Text = String.Empty
                ordered.Text = String.Empty
                proceeded.Text = String.Empty
                note.Text = String.Empty
                finalcheck.Text = String.Empty
                datainput.Text = String.Empty

                con.Close()

            Catch myerror As OleDbException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                con.Dispose()
            End Try
        End If
    End Sub
End Class