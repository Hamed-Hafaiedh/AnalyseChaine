Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub maj_Click(sender As Object, e As EventArgs) Handles maj.Click
        If chaineEntrer.Text <> "" Then
            chaineReturne.Text = chaineEntrer.Text.ToString.ToUpper()
        Else
            MsgBox("entrer un chaine")
        End If
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        If chaineEntrer.Text <> "" Then
            chaineReturne.Text = chaineEntrer.Text.ToString.ToLower()
        Else
            MsgBox("entrer un chaine")
        End If
    End Sub

    Private Sub longu_Click(sender As Object, e As EventArgs) Handles longu.Click
        If chaineEntrer.Text <> "" Then
            chaineReturne.Text = "longueur=" & chaineEntrer.Text.ToString.Length
        Else
            MsgBox("entrer un chaine")
        End If
    End Sub

    Private Sub remp_Click(sender As Object, e As EventArgs) Handles remp.Click
        chaineReturne.Text = chaineEntrer.Text.Replace("o", "O").Replace("a", "A")
    End Sub

    Private Sub decop_Click(sender As Object, e As EventArgs) Handles decop.Click
        Dim mots() As String = chaineEntrer.Text.Split(" "c)
        chaineReturne.Text = String.Join("/", mots)
    End Sub
End Class
