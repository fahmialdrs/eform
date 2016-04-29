Public Class Pembelian
    Private Sub jalankansql(ByVal sQl As String)
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        Try
            objcmd.Connection = conn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sQl
            objcmd.ExecuteNonQuery()
            objcmd.Dispose()
            MsgBox("Data Sudah Disimpan", vbInformation)
        Catch ex As Exception
            MsgBox("Tidak Bisa Menyimpan data ke Database" & ex.Message)
        End Try
    End Sub


    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        membermenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        noform.Text = ""
        userid.Text = ""
        nama.Text = ""
        notelpon.Text = ""
        firmax3r.Value = 0
        o2max3r.Value = 0
        totalpcs.Text = ""
        totalset.Text = ""
        amountr.Text = ""
        ordered.Text = ""
        proceeded.Text = ""
        catatan.Text = ""
        finalcheck.Text = ""
        datainput.Text = ""
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
            Dim simpan As String
            Me.Cursor = Cursors.WaitCursor
            simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3,Total_pcs,Total_set, Amount , catatan , Final_Check, Data_Input , Ordered_by, Proceed_by ) VALUES 
                                   ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & firmax3r.Text & "', '" & o2max3r.Text & "', '" & totalpcs.Text & "','" & totalset.Text & "', '" & amountr.Text & "', '" & catatan.Text & "', '" & finalcheck.Text & "', '" & datainput.Text & "','" & ordered.Text & "','" & proceeded.Text & "') "
            jalankansql(simpan)
            noform.Focus()
            Me.Cursor = Cursors.Default
        End If
    End Sub

End Class