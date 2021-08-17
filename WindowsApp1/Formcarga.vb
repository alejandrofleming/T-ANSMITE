Public Class Formcarga
    Private Sub ComboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPais.SelectedIndexChanged
        Select Case ComboPais.Text
            Case "Argentina"
                ComboCiudad.Items.Clear()
                ComboCiudad.Items.Add("Ciudad Autonoma de Buenos Aires")
                ComboCiudad.Items.Add("Cordoba")
            Case "Venezuela"
                ComboCiudad.Items.Clear()
                ComboCiudad.Items.Add("Caracas")
                ComboCiudad.Items.Add("Lara")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboCiudad.SelectedItem
            Case "Ciudad Autonoma de Buenos Aires"
                FormCaba.Show()
        End Select
    End Sub
End Class