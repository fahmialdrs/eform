Imports System.Data
Imports System.Data.OleDb
Public Class maintainmobile
    Dim mwallet, firmax, o2m, rwallet As Integer

    
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        membermenu.Show()
        Me.Close()
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

        Catch ex As Exception
            MsgBox("Tidak Bisa Menyimpan data ke Database" & ex.Message)
        End Try
    End Sub
    Sub tampilTextBox()
        Try
            Call konek()
            Dim str As String
            str = "SELECT TOP 1 NoForm FROM e_form ORDER BY NoForm DESC;"
            CMD = New OleDbCommand(str, conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                noform.Text = RD.Item("NoForm")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        noform.Text = ""
        userid.Text = ""
        nama.Text = ""
        notelpon.Text = ""
        memberid1.Text = ""
        M1.Text = 0
        R1.Text = 0
        F1.Text = 0
        O1.Text = 0
        memberid2.Text = ""
        M2.Text = 0
        R2.Text = 0
        F2.Text = 0
        O2.Text = 0
        memberid3.Text = ""
        M3.Text = 0
        R3.Text = 0
        F3.Text = 0
        O3.Text = 0
        memberid4.Text = ""
        M4.Text = 0
        R4.Text = 0
        F4.Text = 0
        O4.Text = 0
        memberid5.Text = ""
        M5.Text = 0
        R5.Text = 0
        F5.Text = 0
        O5.Text = 0
        memberid6.Text = ""
        M6.Text = 0
        R6.Text = 0
        F6.Text = 0
        O6.Text = 0
        memberid7.Text = ""
        M7.Text = 0
        R7.Text = 0
        F7.Text = 0
        O7.Text = 0
        memberid8.Text = ""
        M8.Text = 0
        R8.Text = 0
        F8.Text = 0
        O8.Text = 0
        memberid9.Text = ""
        M9.Text = 0
        R9.Text = 0
        F9.Text = 0
        O9.Text = 0
        memberid10.Text = ""
        M10.Text = 0
        R10.Text = 0
        F10.Text = 0
        O10.Text = 0
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        catatan.Text = ""
        ordered.Text = ""
        proceeded.Text = ""
        mwallet = 0
        firmax = 0
        o2m = 0
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
        If userid.Text = "" Then
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
        ElseIf ordered.Text = "" Then
            MessageBox.Show("Kolom Nama Ordered By tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            ordered.Focus()
            Exit Sub
        ElseIf proceeded.Text = "" Then
            MessageBox.Show("Kolom Nama Proceeded By tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            proceeded.Focus()
            Exit Sub
        ElseIf catatan.Text = "" Then
            MessageBox.Show("Kolom Note By tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            catatan.Focus()
            Exit Sub
            'ElseIf bca.Checked = False Or mandiri.Checked = False Or tunai.Checked = False Then
            'MessageBox.Show("Kolom Payment Method By tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            'Exit Sub
            'ElseIf pickup.Checked = False Or delivery.Checked = False Then
            'MessageBox.Show("Kolom Shipping Method By tidak boleh kosong ...", "Peringatan", MessageBoxButtons.OK)
            'Exit Sub
        Else


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
        End If
        While y < x
            If y = 0 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000','" & F1.Text & "', '" & O1.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka1.Text = "1"
                conn.Close()
            ElseIf y = 1 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F2.Text & "', '" & O2.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka2.Text = "2"
                conn.Close()
            ElseIf y = 2 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F3.Text & "', '" & O3.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka3.Text = "3"
                conn.Close()
            ElseIf y = 3 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F4.Text & "', '" & O4.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka4.Text = "4"
                conn.Close()
            ElseIf y = 4 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F5.Text & "', '" & O5.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka5.Text = "5"
                conn.Close()
            ElseIf y = 5 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F6.Text & "', '" & O6.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka6.Text = "6"
                conn.Close()
            ElseIf y = 6 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F7.Text & "', '" & O7.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka7.Text = "7"
                conn.Close()
            ElseIf y = 7 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F8.Text & "', '" & O8.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka8.Text = "8"
                conn.Close()
            ElseIf y = 8 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F9.Text & "', '" & O9.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka9.Text = "9"
                conn.Close()
            ElseIf y = 9 Then
                Dim simpan As String
                Me.Cursor = Cursors.WaitCursor
                simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, amount, Prod_firmax3, Prod_o2_max3, saldo_maintainIDR, kurang_bayar, ordered_by,proceed_by,catatan) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "', '1000000', '" & F10.Text & "', '" & O10.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & ordered.Text & "','" & proceeded.Text & "','" & catatan.Text & "') "
                jalankansql(simpan)
                noform.Focus()
                Me.Cursor = Cursors.Default
                gudang.ReportViewer1.Refresh()
                finance.ReportViewer1.RefreshReport()
                printCMMS.angka10.Text = "10"
                conn.Close()
            End If
            If noform.Text = "" Then
                Call tampilTextBox()
            End If

            y = y + 1
        End While
        MsgBox("Data Sudah Disimpan", vbInformation)
    End Sub

    Private Sub userid_TextChanged(sender As Object, e As EventArgs) Handles userid.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'transfer value to form pembelian
        printCMMS.tanggal.Text = Me.tanggal.Text
        printCMMS.noform.Text = Me.noform.Text
        printCMMS.userid.Text = Me.userid.Text
        printCMMS.nama.Text = Me.nama.Text
        printCMMS.notelp.Text = Me.notelpon.Text
        printCMMS.memberid1.Text = Me.memberid1.Text
        printCMMS.memberid2.Text = Me.memberid2.Text
        printCMMS.memberid3.Text = Me.memberid3.Text
        printCMMS.memberid4.Text = Me.memberid4.Text
        printCMMS.memberid5.Text = Me.memberid5.Text
        printCMMS.memberid6.Text = Me.memberid6.Text
        printCMMS.memberid7.Text = Me.memberid7.Text
        printCMMS.memberid8.Text = Me.memberid8.Text
        printCMMS.memberid9.Text = Me.memberid9.Text
        printCMMS.memberid10.Text = Me.memberid10.Text
        printCMMS.m1.Text = Me.M1.Text
        printCMMS.m2.Text = Me.M2.Text
        printCMMS.m3.Text = Me.M3.Text
        printCMMS.m4.Text = Me.M4.Text
        printCMMS.m5.Text = Me.M5.Text
        printCMMS.m6.Text = Me.M6.Text
        printCMMS.m7.Text = Me.M7.Text
        printCMMS.m8.Text = Me.M8.Text
        printCMMS.m9.Text = Me.M9.Text
        printCMMS.m10.Text = Me.M10.Text
        printCMMS.r1.Text = Me.R1.Text
        printCMMS.r2.Text = Me.R2.Text
        printCMMS.r3.Text = Me.R3.Text
        printCMMS.r4.Text = Me.R4.Text
        printCMMS.r5.Text = Me.R5.Text
        printCMMS.r6.Text = Me.R6.Text
        printCMMS.r7.Text = Me.R7.Text
        printCMMS.r8.Text = Me.R8.Text
        printCMMS.r9.Text = Me.R9.Text
        printCMMS.r10.Text = Me.R10.Text
        printCMMS.f1.Text = Me.F1.Text
        printCMMS.f2.Text = Me.F2.Text
        printCMMS.f3.Text = Me.F3.Text
        printCMMS.f4.Text = Me.F4.Text
        printCMMS.f5.Text = Me.F5.Text
        printCMMS.f6.Text = Me.F6.Text
        printCMMS.f7.Text = Me.F7.Text
        printCMMS.f8.Text = Me.F8.Text
        printCMMS.f9.Text = Me.F9.Text
        printCMMS.f10.Text = Me.F10.Text
        printCMMS.o1.Text = Me.O1.Text
        printCMMS.o2.Text = Me.O2.Text
        printCMMS.o3.Text = Me.O3.Text
        printCMMS.o4.Text = Me.O4.Text
        printCMMS.o5.Text = Me.O5.Text
        printCMMS.o6.Text = Me.O6.Text
        printCMMS.o7.Text = Me.O7.Text
        printCMMS.o8.Text = Me.O8.Text
        printCMMS.o9.Text = Me.O9.Text
        printCMMS.o10.Text = Me.O10.Text
        printCMMS.ordered.Text = Me.ordered.Text
        printCMMS.proceeded.Text = Me.proceeded.Text
        printCMMS.catatan.Text = Me.catatan.Text
        printCMMS.total1.Text = Me.TextBox1.Text
        printCMMS.total2.Text = Me.TextBox2.Text
        printCMMS.total3.Text = Me.TextBox3.Text
        printCMMS.total4.Text = Me.TextBox4.Text
        printCMMS.total5.Text = Me.TextBox5.Text
        printCMMS.yangdibayar.Text = Me.TextBox6.Text

        printCMMS.Show()
        'print
        'printpembelian.Hide()

    End Sub

    Private Sub maintainmobile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userid.Focus()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Dim a, b, c, d, x, f, g, h, i, j As Integer
        a = M1.Text
        b = M2.Text
        c = M3.Text
        d = M4.Text
        x = M5.Text
        f = M6.Text
        g = M7.Text
        h = M8.Text
        i = M9.Text
        j = M10.Text

        mwallet = a + b + c + d + x + f + g + h + i + j
        TextBox1.Text = mwallet
        TextBox5.Text = TextBox1.Text * 3300
        TextBox6.Text = 1000000 - TextBox5.Text
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        Dim a, b, c, d, x, f, g, h, i, j As Integer
        a = O1.Text
        b = O2.Text
        c = O3.Text
        d = O4.Text
        x = O5.Text
        f = O6.Text
        g = O7.Text
        h = O8.Text
        i = O9.Text
        j = O10.Text

        o2m = a + b + c + d + x + f + g + h + i + j
        TextBox4.Text = o2m
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        Dim a, b, c, d, x, f, g, h, i, j As Integer
        a = F1.Text
        b = F2.Text
        c = F3.Text
        d = F4.Text
        x = F5.Text
        f = F6.Text
        g = F7.Text
        h = F8.Text
        i = F9.Text
        j = F10.Text

        firmax = a + b + c + d + x + f + g + h + i + j
        TextBox3.Text = firmax
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Dim a, b, c, d, x, f, g, h, i, j As Integer
        a = R1.Text
        b = R2.Text
        c = R3.Text
        d = R4.Text
        x = R5.Text
        f = R6.Text
        g = R7.Text
        h = R8.Text
        i = R9.Text
        j = R10.Text

        rwallet = a + b + c + d + x + f + g + h + i + j
        TextBox2.Text = rwallet
    End Sub
End Class