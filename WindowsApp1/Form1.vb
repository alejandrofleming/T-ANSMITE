Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cargar_Nombre() <> "" Then
            Formcarga.Show()
        Else
            MsgBox("No ingreso su nombre", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("SOLO PUEDE INGRESAR LETRAS", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Function Cargar_Nombre() As String
        Dim Nombre As String = TextBox1.Text
        With Formcarga
            .Label1.Text = Nombre.ToUpper
        End With
        Return Nombre
    End Function
End Class
