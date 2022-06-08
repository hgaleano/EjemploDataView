Public Class Form1
    Public dvwGenerico As New DataView
    Dim nombreCampoBusqueda As String = "Descripcion"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "data source = .\SQLEXPRESS; initial catalog = Restaurante; user id = sa; password = 123"

        dvwGenerico = generar_datatabla("Select * from UnidadMedida").DefaultView
        dgvLista.DataSource = dvwGenerico
    End Sub
    Sub FiltrarDatos()
        dvwGenerico.RowFilter = nombreCampoBusqueda & " LIKE '" & txtBusqueda.Text & "%'"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        FiltrarDatos()
    End Sub
End Class
