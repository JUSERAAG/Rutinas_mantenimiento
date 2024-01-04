Imports System.Data.SqlClient
Imports Rutinas_mantenimiento.consultas
Public Class FormElectricoDesm1
    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nuevaVentana As New FormPrincipal()
        nuevaVentana.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox10.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress, TextBox12.KeyPress, TextBox13.KeyPress, TextBox14.KeyPress, TextBox15.KeyPress, TextBox16.KeyPress, TextBox17.KeyPress, TextBox18.KeyPress, TextBox19.KeyPress, TextBox20.KeyPress, TextBox21.KeyPress, TextBox22.KeyPress, TextBox23.KeyPress, TextBox24.KeyPress, TextBox25.KeyPress, TextBox26.KeyPress, TextBox27.KeyPress, TextBox28.KeyPress, TextBox29.KeyPress
        ' Verificar que el primer carácter sea un número
        If (sender Is TextBox1 OrElse sender Is TextBox2) AndAlso Char.IsDigit(e.KeyChar) AndAlso (TryCast(sender, TextBox).Text.Length = 0) Then
            ' Primer carácter y es un número
        ElseIf Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "," Then
            e.Handled = True ' Ignorar la tecla presionada
        End If

        ' Permitir solo un punto decimal
        If e.KeyChar = "," AndAlso (TryCast(sender, TextBox).Text.Contains(",") OrElse TryCast(sender, TextBox).SelectionLength > 0) Then
            e.Handled = True ' Ignorar si ya hay un punto decimal o si se seleccionó un rango
        End If
    End Sub

    Private Sub FormElectricoNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized ' Maximizar ventana
        Dim fechaActual As DateTime = DateTime.Now.Date
        Dim horaActual As TimeSpan = DateTime.Now.TimeOfDay
        TextBox30.Text = fechaActual.ToString("yyyy-MM-dd")
        TextBox31.Text = horaActual.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conexion As New SqlConnection(conn)
            Try
                conexion.Open()
                Dim consulta As String = "INSERT INTO dbo.Electrico_Desm1 VALUES (@FECHA,@HORA,@VAR1,@VAR2,@VAR3,@VAR4,@VAR5,@VAR6,@VAR7,@VAR8,@VAR9,@VAR10,@VAR11,@VAR12,@VAR13,@VAR14,@VAR15,@VAR16,@VAR17,@VAR18,@VAR19,@VAR20,@VAR21,@VAR22,@VAR23,@VAR24,@VAR25,@VAR26,@VAR27,@VAR28,@VAR29)"
                Using comando As New SqlCommand(consulta, conexion)
                    ' Agregar parámetros
                    comando.Parameters.AddWithValue("@FECHA", DateTime.Now.Date)
                    comando.Parameters.AddWithValue("@HORA", DateTime.Now.TimeOfDay)
                    comando.Parameters.AddWithValue("@VAR1", Convert.ToSingle(TextBox1.Text))
                    comando.Parameters.AddWithValue("@VAR2", Convert.ToSingle(TextBox2.Text))
                    comando.Parameters.AddWithValue("@VAR3", Convert.ToSingle(TextBox3.Text))
                    comando.Parameters.AddWithValue("@VAR4", Convert.ToSingle(TextBox4.Text))
                    comando.Parameters.AddWithValue("@VAR5", Convert.ToSingle(TextBox5.Text))
                    comando.Parameters.AddWithValue("@VAR6", Convert.ToSingle(TextBox6.Text))
                    comando.Parameters.AddWithValue("@VAR7", Convert.ToSingle(TextBox7.Text))
                    comando.Parameters.AddWithValue("@VAR8", Convert.ToSingle(TextBox8.Text))
                    comando.Parameters.AddWithValue("@VAR9", Convert.ToSingle(TextBox9.Text))
                    comando.Parameters.AddWithValue("@VAR10", Convert.ToSingle(TextBox10.Text))
                    comando.Parameters.AddWithValue("@VAR11", Convert.ToSingle(TextBox11.Text))
                    comando.Parameters.AddWithValue("@VAR12", Convert.ToSingle(TextBox12.Text))
                    comando.Parameters.AddWithValue("@VAR13", Convert.ToSingle(TextBox13.Text))
                    comando.Parameters.AddWithValue("@VAR14", Convert.ToSingle(TextBox14.Text))
                    comando.Parameters.AddWithValue("@VAR15", Convert.ToSingle(TextBox15.Text))
                    comando.Parameters.AddWithValue("@VAR16", Convert.ToSingle(TextBox16.Text))
                    comando.Parameters.AddWithValue("@VAR17", Convert.ToSingle(TextBox17.Text))
                    comando.Parameters.AddWithValue("@VAR18", Convert.ToSingle(TextBox18.Text))
                    comando.Parameters.AddWithValue("@VAR19", Convert.ToSingle(TextBox19.Text))
                    comando.Parameters.AddWithValue("@VAR20", Convert.ToSingle(TextBox20.Text))
                    comando.Parameters.AddWithValue("@VAR21", Convert.ToSingle(TextBox21.Text))
                    comando.Parameters.AddWithValue("@VAR22", Convert.ToSingle(TextBox22.Text))
                    comando.Parameters.AddWithValue("@VAR23", Convert.ToSingle(TextBox23.Text))
                    comando.Parameters.AddWithValue("@VAR24", Convert.ToSingle(TextBox24.Text))
                    comando.Parameters.AddWithValue("@VAR25", Convert.ToSingle(TextBox25.Text))
                    comando.Parameters.AddWithValue("@VAR26", Convert.ToSingle(TextBox26.Text))
                    comando.Parameters.AddWithValue("@VAR27", Convert.ToSingle(TextBox27.Text))
                    comando.Parameters.AddWithValue("@VAR28", Convert.ToSingle(TextBox28.Text))
                    comando.Parameters.AddWithValue("@VAR29", Convert.ToSingle(TextBox29.Text))
                    ' Ejecutar la consulta
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Datos insertados correctamente.")
                End Using
                Dim nuevaVentana As New FormPrincipal()
                nuevaVentana.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Error al insertar datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            Panel1.Enabled = False
        ElseIf Panel1.Visible = False Then
            Panel1.Visible = True
            Panel1.Enabled = True
        End If
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
            Panel2.Enabled = False
        ElseIf Panel2.Visible = False Then
            Panel2.Visible = True
            Panel2.Enabled = True
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
            Panel3.Enabled = False
        ElseIf Panel3.Visible = False Then
            Panel3.Visible = True
            Panel3.Enabled = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Panel4.Visible = True Then
            Panel4.Visible = False
            Panel4.Enabled = False
        ElseIf Panel4.Visible = False Then
            Panel4.Visible = True
            Panel4.Enabled = True
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        If Panel5.Visible = True Then
            Panel5.Visible = False
            Panel5.Enabled = False
        ElseIf Panel5.Visible = False Then
            Panel5.Visible = True
            Panel5.Enabled = True
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        If Panel6.Visible = True Then
            Panel6.Visible = False
            Panel6.Enabled = False
        ElseIf Panel6.Visible = False Then
            Panel6.Visible = True
            Panel6.Enabled = True
        End If
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        If Panel7.Visible = True Then
            Panel7.Visible = False
            Panel7.Enabled = False
        ElseIf Panel7.Visible = False Then
            Panel7.Visible = True
            Panel7.Enabled = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Panel8.Visible = True Then
            Panel8.Visible = False
            Panel8.Enabled = False
        ElseIf Panel8.Visible = False Then
            Panel8.Visible = True
            Panel8.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox2.GotFocus, TextBox3.GotFocus, TextBox4.GotFocus, TextBox5.GotFocus, TextBox6.GotFocus, TextBox7.GotFocus, TextBox8.GotFocus, TextBox9.GotFocus, TextBox10.GotFocus, TextBox10.GotFocus, TextBox10.GotFocus, TextBox11.GotFocus, TextBox12.GotFocus, TextBox13.GotFocus, TextBox14.GotFocus, TextBox15.GotFocus, TextBox16.GotFocus, TextBox17.GotFocus, TextBox18.GotFocus, TextBox19.GotFocus, TextBox20.GotFocus, TextBox21.GotFocus, TextBox22.GotFocus, TextBox23.GotFocus, TextBox24.GotFocus, TextBox25.GotFocus, TextBox26.GotFocus, TextBox27.GotFocus, TextBox28.GotFocus, TextBox29.GotFocus
        ' Obtén el TextBox que ha recibido el foco
        Dim textBoxSeleccionado As TextBox = DirectCast(sender, TextBox)
        textBoxSeleccionado.Text = ""
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus, TextBox2.LostFocus, TextBox3.LostFocus, TextBox4.LostFocus, TextBox5.LostFocus, TextBox6.LostFocus, TextBox7.LostFocus, TextBox8.LostFocus, TextBox9.LostFocus, TextBox10.LostFocus, TextBox10.LostFocus, TextBox10.LostFocus, TextBox11.LostFocus, TextBox12.LostFocus, TextBox13.LostFocus, TextBox14.LostFocus, TextBox15.LostFocus, TextBox16.LostFocus, TextBox17.LostFocus, TextBox18.LostFocus, TextBox19.LostFocus, TextBox20.LostFocus, TextBox21.LostFocus, TextBox22.LostFocus, TextBox23.LostFocus, TextBox24.LostFocus, TextBox25.LostFocus, TextBox26.LostFocus, TextBox27.LostFocus, TextBox28.LostFocus, TextBox29.LostFocus
        ' Obtén el TextBox que ha recibido el foco
        Dim textBoxSeleccionado As TextBox = DirectCast(sender, TextBox)
        If textBoxSeleccionado.Text = "" Then
            textBoxSeleccionado.Text = "0,01"
        ElseIf textBoxSeleccionado.Text <> "0,01" Then
            textBoxSeleccionado.Enabled = False
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "0,01"
        End If
        If TextBox2.Text = "" Then
            TextBox2.Text = "0,01"
        End If
        If TextBox3.Text = "" Then
            TextBox3.Text = "0,01"
        End If
        If TextBox4.Text = "" Then
            TextBox4.Text = "0,01"
        End If
        If TextBox5.Text = "" Then
            TextBox5.Text = "0,01"
        End If
        If TextBox6.Text = "" Then
            TextBox6.Text = "0,01"
        End If
        If TextBox7.Text = "" Then
            TextBox7.Text = "0,01"
        End If
        If TextBox8.Text = "" Then
            TextBox8.Text = "0,01"
        End If
        If TextBox9.Text = "" Then
            TextBox9.Text = "0,01"
        End If
        If TextBox10.Text = "" Then
            TextBox10.Text = "0,01"
        End If
        If TextBox11.Text = "" Then
            TextBox11.Text = "0,01"
        End If
        If TextBox12.Text = "" Then
            TextBox12.Text = "0,01"
        End If
        If TextBox13.Text = "" Then
            TextBox13.Text = "0,01"
        End If
        If TextBox14.Text = "" Then
            TextBox14.Text = "0,01"
        End If
        If TextBox15.Text = "" Then
            TextBox15.Text = "0,01"
        End If
        If TextBox16.Text = "" Then
            TextBox16.Text = "0,01"
        End If
        If TextBox17.Text = "" Then
            TextBox17.Text = "0,01"
        End If
        If TextBox18.Text = "" Then
            TextBox18.Text = "0,01"
        End If
        If TextBox19.Text = "" Then
            TextBox19.Text = "0,01"
        End If
        If TextBox20.Text = "" Then
            TextBox20.Text = "0,01"
        End If
        If TextBox21.Text = "" Then
            TextBox21.Text = "0,01"
        End If
        If TextBox22.Text = "" Then
            TextBox22.Text = "0,01"
        End If
        If TextBox23.Text = "" Then
            TextBox23.Text = "0,01"
        End If
        If TextBox24.Text = "" Then
            TextBox24.Text = "0,01"
        End If
        If TextBox25.Text = "" Then
            TextBox25.Text = "0,01"
        End If
        If TextBox26.Text = "" Then
            TextBox26.Text = "0,01"
        End If
        If TextBox27.Text = "" Then
            TextBox27.Text = "0,01"
        End If
        If TextBox28.Text = "" Then
            TextBox28.Text = "0,01"
        End If
        If TextBox29.Text = "" Then
            TextBox29.Text = "0,01"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
        TextBox13.Enabled = True
        TextBox14.Enabled = True
        TextBox15.Enabled = True
        TextBox16.Enabled = True
        TextBox17.Enabled = True
        TextBox18.Enabled = True
        TextBox19.Enabled = True
        TextBox20.Enabled = True
        TextBox21.Enabled = True
        TextBox22.Enabled = True
        TextBox23.Enabled = True
        TextBox24.Enabled = True
        TextBox25.Enabled = True
        TextBox26.Enabled = True
        TextBox27.Enabled = True
        TextBox28.Enabled = True
        TextBox29.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "" Then
            TextBox1.Enabled = False
        End If
        If TextBox2.Text <> "" Then
            TextBox2.Enabled = False
        End If
        If TextBox3.Text <> "" Then
            TextBox3.Enabled = False
        End If
        If TextBox4.Text <> "" Then
            TextBox4.Enabled = False
        End If
        If TextBox5.Text <> "" Then
            TextBox5.Enabled = False
        End If
        If TextBox6.Text <> "" Then
            TextBox6.Enabled = False
        End If
        If TextBox7.Text <> "" Then
            TextBox7.Enabled = False
        End If
        If TextBox8.Text <> "" Then
            TextBox8.Enabled = False
        End If
        If TextBox9.Text <> "" Then
            TextBox9.Enabled = False
        End If
        If TextBox10.Text <> "" Then
            TextBox10.Enabled = False
        End If
        If TextBox11.Text <> "" Then
            TextBox11.Enabled = False
        End If
        If TextBox12.Text <> "" Then
            TextBox12.Enabled = False
        End If
        If TextBox13.Text <> "" Then
            TextBox13.Enabled = False
        End If
        If TextBox14.Text <> "" Then
            TextBox14.Enabled = False
        End If
        If TextBox15.Text <> "" Then
            TextBox15.Enabled = False
        End If
        If TextBox16.Text <> "" Then
            TextBox16.Enabled = False
        End If
        If TextBox17.Text <> "" Then
            TextBox17.Enabled = False
        End If
        If TextBox18.Text <> "" Then
            TextBox18.Enabled = False
        End If
        If TextBox19.Text <> "" Then
            TextBox19.Enabled = False
        End If
        If TextBox20.Text <> "" Then
            TextBox20.Enabled = False
        End If
        If TextBox21.Text <> "" Then
            TextBox21.Enabled = False
        End If
        If TextBox22.Text <> "" Then
            TextBox22.Enabled = False
        End If
        If TextBox23.Text <> "" Then
            TextBox23.Enabled = False
        End If
        If TextBox24.Text <> "" Then
            TextBox24.Enabled = False
        End If
        If TextBox25.Text <> "" Then
            TextBox25.Enabled = False
        End If
        If TextBox26.Text <> "" Then
            TextBox26.Enabled = False
        End If
        If TextBox27.Text <> "" Then
            TextBox27.Enabled = False
        End If
        If TextBox28.Text <> "" Then
            TextBox28.Enabled = False
        End If
        If TextBox29.Text <> "" Then
            TextBox29.Enabled = False
        End If

    End Sub


End Class