Public Class kalkulator
    Dim bilangan1 As Integer
    Dim bilangan2 As Integer
    Dim operasi As String
    Dim keterangan As Boolean

    Private Sub input(ByVal bilangan As Char)
        If Me.keterangan = True Then
            If (Me.Tampilanutama.Text = "0") Then
                Me.Tampilanutama.Text = Convert.ToString(bilangan)
            Else
                Dim tampilanutama As TextBox = Me.Tampilanutama
                tampilanutama.Text = (tampilanutama.Text & Convert.ToString(bilangan))
            End If
        Else
            Me.Tampilanutama.Text = Convert.ToString(bilangan)
            Me.keterangan = True
        End If
    End Sub
    Private Sub inputOperator(ByVal uperator As String)
        If (Me.Tampilanutama.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.bilangan1 = Convert.ToInt32(Me.Tampilanutama.Text)
                Me.Tampilanutama.Text = Me.bilangan1.ToString
                Me.keterangan = False
            Else
                Me.hitung()
            End If
            Me.operasi = uperator
        End If
    End Sub
    Private Sub hitung()
        Me.bilangan2 = Convert.ToInt32(Me.Tampilanutama.Text)
        Select Case Me.operasi
            Case "+"
                Me.bilangan1 = (Me.bilangan1 + Me.bilangan2)
                Exit Select
            Case "-"
                Me.bilangan1 = (Me.bilangan1 - Me.bilangan2)
                Exit Select
        End Select
        Me.Tampilanutama.Text = Me.bilangan1.ToString
        Me.keterangan = False
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If (Me.keterangan AndAlso (Me.Tampilanutama.Text <> "0")) Then
            Dim tampilanutama As TextBox = Me.Tampilanutama
            tampilanutama.Text = tampilanutama.Text & "0"
        End If
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Me.inputOperator("+")
    End Sub

    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        Me.inputOperator("-")
    End Sub

    Private Sub samadengan_Click(sender As Object, e As EventArgs) Handles samadengan.Click
        If ((Me.Tampilanutama.Text <> "0") And (bilangan1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Me.Tampilanutama.Text = "0"
        Me.bilangan1 = 0
        Me.operasi = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.input("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.input("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.input("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.input("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.input("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.input("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.input("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.input("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.input("9")
    End Sub

    Private Sub Tampilanutama_TextChanged(sender As Object, e As EventArgs) Handles Tampilanutama.TextChanged

    End Sub
End Class

