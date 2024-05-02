Public Class Form1


    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        TxtUser.Text = ""
        TxtPass.Text = ""
        'le paso el foco al txtuser
        TxtUser.Focus()


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'salgo de la aplicacion
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtUser.Text <> "" Then
            If TxtPass.Text <> "" Then
                If TxtUser.Text = "admin" And TxtPass.Text = "1234" Then
                    MsgBox("Bienvenido al sistema")
                    'envio al formulario de principal
                    Me.Hide()
                    FrmPrincipal.Show()
                Else
                    MsgBox("Usuario o contraseña incorrecta", vbExclamation)
                    'limpio los campos
                    TxtUser.Text = ""
                    TxtPass.Text = ""
                    'le paso el foco al txtuser
                    TxtUser.Focus()
                End If
            Else
                MsgBox("Ingrese la contraseña", vbExclamation)
                TxtPass.Focus()
            End If
        Else
            MsgBox("Ingrese el usuario", vbExclamation)
            TxtUser.Focus()
        End If
    End Sub


End Class
