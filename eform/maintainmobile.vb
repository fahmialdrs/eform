Public Class maintainmobile
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        membermenu.Show()
        Me.Hide()
    End Sub
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        noform.Text = ""
        userid.Text = ""
        nama.Text = ""
        notelpon.Text = ""
        memberid1.Text = ""
        M1.Text = ""
        R1.Text = ""
        F1.Text = ""
        O1.Text = ""
        memberid2.Text = ""
        M2.Text = ""
        R2.Text = ""
        F2.Text = ""
        O2.Text = ""
        memberid3.Text = ""
        M3.Text = ""
        R3.Text = ""
        F3.Text = ""
        O3.Text = ""
        memberid4.Text = ""
        M4.Text = ""
        R4.Text = ""
        F4.Text = ""
        O4.Text = ""
        memberid5.Text = ""
        M5.Text = ""
        R5.Text = ""
        F5.Text = ""
        O5.Text = ""
        memberid6.Text = ""
        M6.Text = ""
        R6.Text = ""
        F6.Text = ""
        O6.Text = ""
        memberid7.Text = ""
        M7.Text = ""
        R7.Text = ""
        F7.Text = ""
        O7.Text = ""
        memberid8.Text = ""
        M8.Text = ""
        R8.Text = ""
        F8.Text = ""
        O8.Text = ""
        memberid9.Text = ""
        M9.Text = ""
        R9.Text = ""
        F9.Text = ""
        O9.Text = ""
        memberid10.Text = ""
        M10.Text = ""
        R10.Text = ""
        F10.Text = ""
        O10.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        ordered.Text = ""
        proceeded.Text = ""
    End Sub

    Private Sub bca_CheckedChanged(sender As Object, e As EventArgs) Handles bca.CheckedChanged
        If bca.Checked = True Then
            catatan.Text &= " \\ Transfer BCA"
        ElseIf bca.Checked = False Then
            catatan.Text &= " "

        End If
    End Sub

    Private Sub mandiri_CheckedChanged(sender As Object, e As EventArgs) Handles mandiri.CheckedChanged
        If mandiri.Checked = True Then
            catatan.Text &= " \\ Transfer Mandiri"
        ElseIf mandiri.Checked = False Then
            catatan.Text &= " "
        End If
    End Sub

    Private Sub tunai_CheckedChanged(sender As Object, e As EventArgs) Handles tunai.CheckedChanged
        If tunai.Checked = True Then
            catatan.Text &= " \\ Tunai"
        ElseIf tunai.Checked = False Then
            catatan.Text &= " "
        End If
    End Sub

    Private Sub pickup_CheckedChanged(sender As Object, e As EventArgs) Handles pickup.CheckedChanged
        If pickup.Checked = True Then
            catatan.Text &= " \\ Pick Up"
        ElseIf pickup.Checked = False Then
            catatan.Text &= " "
        End If
    End Sub

    Private Sub delivery_CheckedChanged(sender As Object, e As EventArgs) Handles delivery.CheckedChanged
        If delivery.Checked = True Then
            catatan.Text &= " \\ Delivery"
        ElseIf delivery.Checked = False Then
            catatan.Text &= " "
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        y = 0

        If memberid2.Text = "" Then
            x = 1
        ElseIf memberid3.Text = "" Then
            x = 2
        ElseIf memberid4.Text = "" Then
            x = 3
        ElseIf memberid5.Text = "" Then
            x = 4
        ElseIf memberid6.Text = "" Then
            x = 5
        ElseIf memberid7.Text = "" Then
            x = 6
        ElseIf memberid8.Text = "" Then
            x = 7
        ElseIf memberid9.Text = "" Then
            x = 8
        ElseIf memberid10.Text = "" Then
            x = 9
        Else
            x = 10
        End If

        While y < x
            If y = 0 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp,Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F1.Text & "', '" & O1.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 1 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F2.Text & "', '" & O2.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 2 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F3.Text & "', '" & O3.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 3 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F4.Text & "', '" & O4.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 4 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F5.Text & "', '" & O5.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 5 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F6.Text & "', '" & O6.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 6 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F7.Text & "', '" & O7.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 7 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F8.Text & "', '" & O8.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 8 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F9.Text & "', '" & O9.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
            ElseIf y = 9 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(NoForm,Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3) VALUES ('" & noform.Text & "','" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & F10.Text & "', '" & O10.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
            End If


            y = y + 1
        End While

    End Sub

    Private Sub userid_TextChanged(sender As Object, e As EventArgs) Handles userid.TextChanged

    End Sub
End Class