'importo el conector de mysql
Imports MySql.Data.MySqlClient

Public Class AltaProductos
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub AltaPrductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'conecto con la base de datos
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=localhost;user id=root;password=;database=la_despensa"
        'preparo la consulta para agregar un nuevo registro
        Dim cmd As New MySqlCommand
        cmd.Connection = conexion
        cmd.CommandText = "INSERT INTO productos (nombre, descripcion, precio, stock, id_categoria) VALUES (@nombre, @descripcion, @precio, @stock, @id_categoria)"
        cmd.Parameters.AddWithValue("@nombre", TextBox1.Text)
        cmd.Parameters.AddWithValue("@descripcion", TextBox2.Text)
        cmd.Parameters.AddWithValue("@precio", TextBox3.Text)

        'verifico que el stock sea un numero
        If IsNumeric(TextBox4.Text) Then
            cmd.Parameters.AddWithValue("@stock", TextBox4.Text)
        Else
            MsgBox("El stock debe ser un número")
            Exit Sub
        End If
        'ejecuto el comando
        Try
            conexion.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Producto agregado correctamente")
        Catch ex As Exception
            MsgBox("Error al agregar el producto: " & ex.Message)
        End Try



        'conexion.conectar()
        ''creo la consulta
        'Dim sql As String = "INSERT INTO productos (nombre, descripcion, precio, stock, id_categoria) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & ComboBox1.SelectedValue & "')"
        ''ejecuto la consulta
        'conexion.ejecutar(sql)
        ''cierro la conexion
        'conexion.desconectar()
        ''limpio los campos
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        'TextBox3.Text = ""
        'TextBox4.Text = ""
        'ComboBox1.SelectedIndex = -1
    End Sub
End Class