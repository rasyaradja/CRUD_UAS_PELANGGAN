Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ViewData()
    End Sub

    Sub ViewData()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * From pelanggan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pelanggan")
        DataGridView1.DataSource = (Ds.Tables("pelanggan"))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1_Rasya.Text = "" Or TextBox2_Rasya.Text = "" Or TextBox3_Rasya.Text = "" Or TextBox4_Rasya.Text = "" Or TextBox5_Rasya.Text = "" Then
            MsgBox("Pastikan Semua Field Terisi")
        Else
            Call Koneksi()
            Dim cmd As OdbcCommand
            Dim simpan As String = "Insert into pelanggan values ('" & TextBox1_Rasya.Text & "','" & TextBox2_Rasya.Text & "','" & TextBox3_Rasya.Text & "','" & TextBox4_Rasya.Text & "','" & TextBox5_Rasya.Text & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Input")
            Call ViewData()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1_Rasya.Text = "" Or TextBox2_Rasya.Text = "" Or TextBox3_Rasya.Text = "" Or TextBox4_Rasya.Text = "" Or TextBox5_Rasya.Text = "" Then
            MsgBox("Pastikan Semua Field Terisi")
        Else
            Call Koneksi()
            Dim cmd As OdbcCommand
            Dim EditData As String = "Update pelanggan set NAMA= '" & TextBox2_Rasya.Text & "',ALAMAT='" & TextBox3_Rasya.Text & "',TELP ='" & TextBox4_Rasya.Text & "',EMAIL ='" & TextBox5_Rasya.Text & "' where ID = '" & TextBox1_Rasya.Text & "'"
            cmd = New OdbcCommand(EditData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Edit")
            Call ViewData()

        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1_Rasya.Text = "" Or TextBox2_Rasya.Text = "" Or TextBox3_Rasya.Text = "" Or TextBox4_Rasya.Text = "" Or TextBox5_Rasya.Text = "" Then
            MsgBox("Pastikan Data yang akan dihapus Terisi")
        Else
            If MessageBox.Show("Apakah Ykin Data Akan Dihapus ?", "Peringatan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Call Koneksi()
                Dim HapusData As String = "Delete From pelanggan where ID ='" & TextBox1_Rasya.Text & "'"
                cmd = New OdbcCommand(HapusData, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus")
                Call ViewData()
            End If
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Apakah Yakin Akan Keluar?", "Info", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub TextBox1_Rasya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1_Rasya.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                'Dim cmd As OdbcCommand
                cmd = New OdbcCommand("Select * From pelanggan Where ID ='" & Trim(TextBox1_Rasya.Text) & "'", Conn)
                Rd = cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    TextBox2_Rasya.Text = Rd.Item("NAMA")
                    TextBox3_Rasya.Text = Rd.Item("ALAMAT")
                    TextBox4_Rasya.Text = Rd.Item("TELP")
                    TextBox5_Rasya.Text = Rd.Item("EMAIL")
                Else
                    MsgBox("Data Tidak Ada")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1_Rasya.Text = ""
        TextBox2_Rasya.Text = ""
        TextBox3_Rasya.Text = ""
        TextBox4_Rasya.Text = ""
        TextBox5_Rasya.Text = ""
    End Sub
End Class
