Imports System.Data.Odbc
Public Class FormLogin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Sub Terbuka()

        FormMenuUtama.LoginToolStripMenuItem.Visible = False
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.MasterToolStripMenuItem.Visible = True
        FormMenuUtama.LaporanToolStripMenuItem.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1_Rasya.Text = "" Or TextBox2_Rasya.Text = "" Then
            MsgBox("Username dan Password Tidak Boleh Kosong")
        Else
            Call Koneksi()
            cmd = New Odbc.OdbcCommand("Select * From tbl_users where username='" & TextBox1_Rasya.Text & "' and userpwd='" & TextBox2_Rasya.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("Berhasil Login")
                Me.Close()
                Call Terbuka()
            Else
                MsgBox("Username dan Password salah")
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2_Rasya.PasswordChar = "*"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2_Rasya.PasswordChar = ""
        Else
            TextBox2_Rasya.PasswordChar = "*"
        End If
    End Sub
End Class
