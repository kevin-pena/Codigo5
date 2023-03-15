Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vector(4) As String
        Dim buscar, posicion As String
        vector(0) = "kevin"
        vector(1) = "Juan"
        vector(2) = "Saul"
        vector(3) = "Chino"
        vector(4) = "Marvin"

        buscar = Me.TbxBuscar.Text

        For i = 0 To vector.Length - 1
            If buscar = vector(i) Then
                posicion = 1
            End If
            MsgBox(vector(i))
        Next
        If posicion = "" Then
            MsgBox("No se encontro el dato")

        Else
            MsgBox("la posicion dentro del vector de la busqueda es:" & posicion)
        End If
    End Sub
End Class
