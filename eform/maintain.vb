﻿Imports System.Data
Imports System.Data.OleDb
Public Class maintain
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
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        membermenu.Show()
        Me.Close()
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        ElseIf totalpcs.Text > 2 Then
            MessageBox.Show("Pembelian minimal 1 pcs Firmax3 dan 1 pcs O2 MAX3 ...", "Peringatan", MessageBoxButtons.OK)
            firmax3r.Focus()
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
            simpan = "INSERT INTO e_form(Tanggal,user_id,nama, No_Telp, Prod_firmax3, Prod_o2_max3,Total_pcs,Total_set, Amount , catatan , Ordered_by, Proceed_by,saldo_maintainRM,saldo_maintainIDR,kurang_bayar ) VALUES ('" & tanggal.Text & "','" & userid.Text & "','" & nama.Text & "','" & notelpon.Text & "','" & firmax3r.Text & "', '" & o2max3r.Text & "', '" & totalpcs.Text & "','" & totalset.Text & "', '" & amountr.Text & "', '" & catatan.Text & "', '" & ordered.Text & "','" & proceeded.Text & "', '" & saldomaintainrm.Text & "','" & saldomaintainidr.Text & "','" & kurangbayar.Text & "') "
            jalankansql(simpan)
            noform.Focus()
            If noform.Text = "" Then
                Call tampilTextBox()
            End If
            Me.Cursor = Cursors.Default
            conn.Close()
        End If

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'transfer value to form pembelian
        printAM.tanggal.Text = Me.tanggal.Text
        printAM.no.Text = Me.noform.Text
        printAM.userid.Text = Me.userid.Text
        printAM.nama.Text = Me.nama.Text
        printAM.notelp.Text = Me.notelpon.Text
        printAM.saldomaintain.Text = Me.saldomaintainrm.Text
        printAM.saldomaintain2.Text = Me.saldomaintainidr.Text
        printAM.totalpcs.Text = Me.totalpcs.Text
        printAM.totalset.Text = Me.totalset.Text
        printAM.kurangbayar.Text = Me.kurangbayar.Text
        printAM.firmax3.Text = Me.firmax3r.Text
        printAM.o2max3.Text = Me.o2max3r.Text
        printAM.amount.Text = Me.amountr.Text
        printAM.ordered.Text = Me.ordered.Text
        printAM.proceeded.Text = Me.proceeded.Text
        printAM.catatan.Text = Me.catatan.Text
        printAM.Show()

    End Sub

    Private Sub maintain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userid.Focus()
    End Sub

    Private Sub saldomaintainrm_TextChanged(sender As Object, e As EventArgs) Handles saldomaintainrm.TextChanged
        Try
            If saldomaintainrm.Text >= 0 Or saldomaintainrm.Text <> "" Then
                saldomaintainidr.Text = saldomaintainrm.Text * 3300
                kurangbayar.Text = 1000000 - saldomaintainidr.Text
            End If
        Catch ex As Exception
            MessageBox.Show("Kolom Saldo Maintain RM tidak boleh kosong" & ex.Message, "Peringatan", MessageBoxButtons.OK)
        End Try
    End Sub
End Class